# MonoGame-XNA-Starting-point
Microsoft XNA Game Studio 4.0: Learn Programming Now!
Book by Rob S. Miles

In this chapter we will
Explore how games actually works.
See how data is stored in a program.
Discover how colors are managed on computers.
Find out about classes and methods.
Write some code that makes decisions.
Create a funky color-changing mood light.

To see how a game program can produce a display we need to look inside one of the C# programs that XNA built.
The file that contains the game behaviour is called Game1.cs, the name was generated automatically and .cs is the file extension for C# programs.
Game1.cs has game methods: “protected override void …”.
A method is a named part of a program. 
We can add comments into the program by adding \\. The text (comments) that come after \\ are ignored by the compiler.  

Clear in ta method that is part of the XNA.  The Clear method clears the screen to the color. The screen clour can be cleared to Red as following:

If you run the program with the new line of code the screen is set to red.
Or change that to Teal which is blue/green colour

The preceding statement sets the background color to a color value defined below.
The color order is (red,green,blue) and are in a range of [0,255].

Light to change color over time to get a smooth mood light effect 
Games and Classes
The game program is actually a class called Game1. A class is a collection of abilities (methods) and data (variables) that forms part of a program. 
A class is usually constructed to look after one particular part of a system.
Class and Behaviour
A behaviour is something that a class can be asked to do. A particular method performs a particular behaviour. 
The Game1 class provides Update and Draw behaviours so that XNA can ask Game1 to update the state of the game and draw it on the display.
When you create a game, you must create the variables that hold the statement of the game itself. 
Position of a car, speed of a car a player is driving are called game world data.
In the Mood Light the world data is the amount of red, green blue that defines the color of the light.
Local variables are used when you just want to manipulate some data for a very short time. In this case, program makes a color value that can be fed into the Clear method.
At the moment, the value of backgroundcolor is constructed from the value 255,255,0, which gives the amount of red, green and blue in the color. We want to construct the color value from game data values that are set up by the Update method.
To make the light work the program must store the game data in a place where both the Draw and Update methods can use it.
The Update method updates the game world data and Draw method use it to draw the display.
The XNA calls Draw and Update at regular intervals when the game is running. 
For the MoodLight game the data will be the brightness of the red, green and blue components of the color of the light to be produced.
The proceeding code declares three variables inside the Game1 class and are the members of the class.
The data for each color intensity is being held in a variable of type byte. The byte type  uses 8 bits of computer memory to hold the value that is trying to represent.
Anything in update method will be called 60 times a second. When the redIntensity++; is called in update. It means that is redCountingUp is True, the red intensity of the screen gets progressively brighter over time.


Chapter 3:
Find out how MonoGame xna represents the gamepads and keyboards.
Discover the C# language structures that let us get player input. 
Write some really silly games and scare people with them.

Introduction:
You know how the basics of computer game programming and how a program is a sequence of statements, each of which performs a single action.
You have seen that statements are held inside methods, each of which performs a particular task, and that methods are held in classes along with data.
The program works on data values, which are held in variables of a particular type, and the program can make decisions based on the values that the variables.
Now we are going to expand the knowledge to receive input from the outside world so that games can actually react to what the player does.

We want to write some code that says, “if the red button on Gamepad1 is being pressed, increase the value of redIntensity by 1”. This way we can create a user-controlled light easily. 
XNA provides support for up to four game pads connected simultaneously.
The gamepad information is represented by “GamePadState”.
The GamePad class contains a method called “GetState” which gets the state of one of the gamepads.

Controlling the Vibration of a Gamepad:
The GamePad class provides a method called “SetVibration” that lets a program control the vibration motors:
It uses a three parameters (which game pad to vibrate, this parameter is [0,1] that controls the vibration of the left motor, (the bigger the number, the more the gamepad vibrates), the third parameter controls the right motor in the same way as the left one).
Testing Intensity Value:

Chapter 4:
Displaying Images
In the solution Explorer open the Content Folder  right click the Content.mgcb  openWithMonoGame Pipeline Tool and hit OK
EditAdd Existing Item browse and find the images saved on the hard drive
Pick Build from the main menu  and Build –> ok.
Add the code highlighted in red to the Game1.cs
LoadContent” method has the responsibility of loading all the contents and make them ready for use.
In addition to loading the content it creates a “SpriteBatch” for the program to use.
In MonoGame the image is a sprite, A sprite is a flat, preloaded image that is used as part of a computer game.
To locate a sprite on the screen we use “Rectangle”. It holds information about the position and size of a rectangle.
The position of the rectangle is given by the coordinates of its top left corner. You express a position on the screen by giving an x coordinate value (the distance from left to right) and a y coordinate value (the distance down the screen from top).
It means that the position with the coordinate of (0,0) is the top left corner.
The rectangle gets the coordinates of the top left corner of an image location as well as the Width and Height in pixels.
When a rectangle is created it passes the( x,y, width, height) values that will be held within rectangle structure.
It means that if we ever wanted to move the image or change its size on the screen we need to change only one of the values that is held in the rectangle.
The rectangle needs to be created when the game program starts. 
  -Set things up: Initialize
  -Load game Content: LoadContent
  -Repeatedly update the game and draw the display: Draw and Update
  -Free up all the content: UnloadContent

