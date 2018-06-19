using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{	
public Text text;
private enum States {start, later, study, test, docs, visa, illegal, survey, end};
private States myState;

// Use this for initialization
void Start ()
{
	myState = States.start;
}

// Update is called once per frame
void Update (){
	print(myState);
		if (myState == States.start){
		start();
		} else if(myState == States.later){
			later();
		} else if(myState == States.study){
			study();
		} else if(myState == States.test){
			test();
		} else if(myState == States.docs){
			docs();
		} else if(myState == States.visa){
			visa();
		} else if(myState == States.illegal){
			illegal();
		} else if(myState == States.survey){
			survey();
		} else if(myState == States.end){
			end();
		}
}
	
#region handle statement method

	void start(){
		text.text = "You want to get out of the country as soon as possible! " + 
					"Corruption and crimes become frequent and getting worse every day. " +
					"How start a journey to the United Kingdom if you don't even speak English? \n\n" +						
					"Press S to Study English or L to think about it Later" ;				
			if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.later;
			}else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.study;
			}
		}
		
	void later(){
		text.text = "Good communication skills are essential to any task. " +
					"You may not succeed in a new country with different language and culture if you are unable to communicate. " +
					"The study comes first. Get prepared now!\n\n" +
					"Press R to Return." ;
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.start;
		}
	}
		
	void study(){
		text.text = "You have decided to test your English level watching BBC News " + 
					"but, you can't understand the British accent. What you gonna do? \n\n" +
					"Press S to Study more or I to Ignore the language";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.test;
		}else if(Input.GetKeyDown(KeyCode.I)){
			myState = States.later;
		}
	}
	
	void test(){
		text.text = "Only good English level isn't enough to live in the UK. " + 
					"You must hold documents from one of the 28 countries of the European Union (EU) " +
					"or apply for a Visa. On the other hands, it is not recommended to stay illegal.\n\n" +
					"Press E to learn more about European docs, V to apply for a Visa or I to stay Illegal ";
		if (Input.GetKeyDown(KeyCode.L)){
			myState = States.docs;
		}else if(Input.GetKeyDown(KeyCode.I)){
			myState = States.illegal;
		}else if(Input.GetKeyDown(KeyCode.V)){
			myState = States.visa;
	}
}
	
	void docs(){
		text.text = "You can require EU docs if you are a family member from Austria, Belgium, Bulgaria, Croatia, Republic of Cyprus, Czech Republic, " + 
					"Denmark, Estonia, Finland, France, Germany, Greece, Hungary, Ireland, Italy, Latvia, Lithuania, Luxembourg, " + 
					"Malta, Netherlands, Poland, Portugal, Romania, Slovakia, Slovenia, Spain, Sweden and the UK. " + 
					"Keep in mind that each country has your own policy about family members. \n\n" +
					"Press S to do a Survey about your family tree or I to Ignore it.";
		if (Input.GetKeyDown(KeyCode.I)){
			myState = States.illegal;
		}else if(Input.GetKeyDown(KeyCode.S)){
		myState = States.survey;
		}
	}
	
	void visa(){
		text.text = "You have decided to apply online for a UK visa (visit, work, study, tourist, or join a family member or partner in the UK).\n\n" + 
					"Press S to check the visa Status or I to Ignore it.";
		if (Input.GetKeyDown(KeyCode.I)){
			myState = States.illegal;
		}else if(Input.GetKeyDown(KeyCode.S)){
		myState = States.end;
		}
	}
	
	void illegal(){
		text.text = "As illegal you can get arrested, deported and have your name in the immigration blacklist for long years. " + 
					"Even if you succeed in crossing the border, as illegal you haven't any support or right like a hospital, schools, jobs, etc. "+ 
					"Employers can't hire illegal immigrants, it can cost a small fortune in penalties. " +
					"Give up on the illegal idea and do it on right way.\n\n" +
					"Press R to Return." ;
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.test;
		}
	}
	
	void survey(){
		text.text = "Someone in your family has belonged (or still belongs if alive) to one of the EU countries, " + 
					"and you have started to check for more information about that person. " +
					"In your survey, the law of the country of your relative " +
					"may allow you the right to become a citizen of that country too. " +
					"Also, may the same rules apply for marriage with EU citizen. \n\n" +
					"Press E to become EU citizen or N if you don't have the right";
					
		if (Input.GetKeyDown(KeyCode.E)){
			myState = States.end;
		} else if (Input.GetKeyDown(KeyCode.N)){
		myState = States.test;
		}
	}
	
	void end(){
		text.text = "Your heart races as you get the documentation that allows you to stay in the UK. \n\n" + 
					"Have a good flight and I wish you all the best in your new life journey. \n\n" + 
					"Press P to Play again.";
					
		if (Input.GetKeyDown(KeyCode.P)){
			myState = States.start;
		}
	}
			
		#endregion		
}