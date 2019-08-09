using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

  public float speed;
  public Text countText;
  public Text winText;
  public Text timeText;

  private Rigidbody rb;
  private int count;
  private int deactive;
  private int index;
  private float startTime;

  private GameObject[] cubes;


  void Start(){
    rb = GetComponent<Rigidbody>();
    count = 0;
    deactive = 0;
    SetCountText ();
    winText.text = "";

    cubes = GameObject.FindGameObjectsWithTag("Pick Up");
    //startTime = Time.time;
  }
  void FixedUpdate(){
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    rb.AddForce(movement * speed);

  }

  void Update(){
    //float t = Time.time - startTime;
    float t = Time.time;
    string minutes = ((int)(t / 60)).ToString();
    string seconds = ((int)(t % 60)).ToString();
    if ((t % 60) < 10){
      timeText.text = minutes + ":0" + seconds;
    }
    else{
      timeText.text = minutes + ":" + seconds;
    }
  }

  void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("Pick Up")){
      other.gameObject.SetActive(false);
      count++;
    }
    SetCountText();
  }

  void OnCollisionEnter(Collision other){
    if (other.gameObject.CompareTag("Collision")){
      count--;
      CreateCubes();
      SetCountText();
    }
  }

  void SetCountText (){
    countText.text = "Count:"+ count.ToString ();
    if (count == 12){
      winText.text = "You win!";
    }
    if (count < 0){
      count = 0;
    }
  }

  void CreateCubes (){
    index = Random.Range(0, cubes.Length);
    for (int i = 0; i < cubes.Length; i++){
      if (cubes[i].activeSelf == false){
        deactive++;
      }
    }
    if (deactive > count){
      for (int j = 1; j < deactive - count; j++){
        cubes[index].SetActive(true);
      }
    }
  }


}
