## ArduArm - controller  
A 2-DOF robot arm controller in C#  
  
![ArduArm_controller](/ArduArm-Controller.jpg)  
  
![ArduArm_controller](/ArduArm-icons.jpg)  
  
This software solves the degree of 2 servo's (shoulder & elbow) to place an end effector at a given X/Y position.  
It also allows you to draw a shape and save/load it, and play it back over a serial connection.  
  
Originally written in 2013 but recently found in a backup i thought i would post the code since it might be useful to anyone doing forward/inverse kinematics to control a robot arm using servo motors.  
  
It's not the cleanest code and didn't make it much past concept phase but all the math checks out and as you can see in the first demo video below it has the ability to be very precise.  
My attempt at building the robot arm didn't go so well, only had some old shaky servo's on hand at the time.  
  
Here's a video of it in action  
https://www.youtube.com/watch?v=FexRn0dznxI  
  
This is it working...using the only servo's i had in my parts bin at the time (very bad servos)  
https://www.youtube.com/watch?v=Bt2EiDSwcJs  
  
  
For arduino code see file ArduArm_serial.ino