#include <Servo.h> 
 
Servo shoulder;
Servo elbow;
Servo wrist;

int tempInt;

int cmd_1 = 0;
int cmd_2 = 0;
int cmd_3 = 0;
int cmd_4 = 0;
int cmd_5 = 0;
int cmd_6 = 0;
int cmd_7 = 0;
int cmd_8 = 0;

int cmdCount = 0;

void setup()
{ 
  delay(1000);
  Serial.begin(9600);
  delay(1000);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  
  digitalWrite(7,HIGH);
  setColour(0);
  
  shoulder.attach(9);
  elbow.attach(10);
  wrist.attach(11);
  delay(250);
  shoulder.writeMicroseconds(1500); 
  elbow.writeMicroseconds(1500); 
  wrist.writeMicroseconds(1500); 
  delay(250);
} 

void loop(){
  if(Serial.available())
    {
      int tempInt = (unsigned char)Serial.read();
      
      
      if(cmdCount==0){cmd_1=tempInt;}
      if(cmdCount==1){cmd_2=tempInt;}
      if(cmdCount==2){cmd_3=tempInt;}
      if(cmdCount==3){cmd_4=tempInt;}
      if(cmdCount==4){cmd_5=tempInt;}
      if(cmdCount==5){cmd_6=tempInt;}
      if(cmdCount==6){cmd_7=tempInt;}
      if(cmdCount==7){cmd_8=tempInt;}
      
      cmdCount++;
      
      if(cmdCount==7){
        cmdCount=0;
         Serial.println(cmd_1);
         Serial.println(cmd_2);
         Serial.println(cmd_3);
         Serial.println(cmd_4);
         Serial.println(cmd_5);
         Serial.println(cmd_6);
         Serial.println(cmd_7);
         Serial.println(cmd_8);
         Serial.println("EOC");
         
        if(cmd_8!=8){
          setColour(1);
          Serial.println("ERR");
        }else{
         setColour(2);
         shoulder.writeMicroseconds(cmd_1+1000); 
         elbow.writeMicroseconds(cmd_2+1000);  
        
        }
      }
    }
}
 
 int reMap(int inVal){
   return map(inVal, 0, 150, 0, 700);
 }
 
 void SetShoulder(int inX){   // 0 - 1000
     shoulder.writeMicroseconds(inX+1000); 
 }
 
 void SetElbow(int inY){   // 0 - 1000
     elbow.writeMicroseconds(inY+1000); 
 }
 
 void SetWrist(int inZ){   // 0 - 1000
     wrist.writeMicroseconds(inZ+1000); 
 }
 
 
 void setColour(int inColour){
    if(inColour==0){  // OFF
        digitalWrite(4,HIGH);
        digitalWrite(5,HIGH);
        digitalWrite(6,HIGH);
    }
    if(inColour==1){  // RED
        digitalWrite(4,LOW);
        digitalWrite(5,HIGH);
        digitalWrite(6,HIGH);
    }
    if(inColour==2){  // GREEN
        digitalWrite(4,HIGH);
        digitalWrite(5,LOW);
        digitalWrite(6,HIGH);
    }
    if(inColour==3){  // BLUE
        digitalWrite(4,HIGH);
        digitalWrite(5,HIGH);
        digitalWrite(6,LOW);
    }
 }



