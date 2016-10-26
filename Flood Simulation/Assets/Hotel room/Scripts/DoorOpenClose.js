#pragma strict
public var isRunning = false;
private var anim:Animation;
var OpenSound : AudioClip;
var CloseSound : AudioClip;
var Door : GameObject;

function Awake (){
  
   anim = this.GetComponent.<Animation>();
}

function OnMouseDown(){
 if(!isRunning){
 GetComponent.<AudioSource>().PlayOneShot(OpenSound);
 Door.GetComponent.<Animation>().Play("Open");
 }else{
 GetComponent.<AudioSource>().PlayOneShot(CloseSound);
 Door.GetComponent.<Animation>().Play("Close");
 }
 isRunning =!isRunning;
 }
 function playAnim(s:String){
    anim.Blend(s);
    }