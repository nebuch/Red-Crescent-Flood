var triggered:boolean=false;
var Style:GUIStyle;
var Image : Texture;

 function Start()
    {      
            Screen.lockCursor = true;
    }
            
function OnMouseEnter(){
	
		triggered = true;
}
function OnMouseExit(){
	
		triggered = false;
}

function OnGUI(){
	if(triggered){
		GUI.Label(new Rect(Screen.width/2-50,Screen.height/2-50,400,400),"Click on mouse",Style);
		GUI.Label(Rect((Screen.width - Image.width) /2, (Screen.height - Image.height) /2, Image.width, Image.height), Image);
	}
}
