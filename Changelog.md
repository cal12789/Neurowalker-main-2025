# Neurowalker
Version Control for Neurowalker VR Project

V2.0

Version Log for Neurowalker Build 1.40    
    
Created new player XR rig that will allow for greater control and flexibility     
Properly setup Unity play mode with headset and controller tracking to replace old build and run model for testing    
Created tech demo scene and moved all non-anatomical objects into this new scene    
Updated backend scripts with better documentation as well as simplified some methods    
Increased the continous movement speed of the player 1 -> 5    
Fixed menu open/close using only the options button on touch controllers -> now opens and closes properly with just the options button    
Added UIcanvas on left hand to display current location of the player -> change to location later by using colliders that change a text variable that will be assigned to displayLocation    
Fixed teleportation layers so that an object can be teleported and sliced but does not need to be sliced on the default layer (default layer can now be used for teleporting and non-slicing) and we stll have slicing functionality    
    
V1.25 Changelog  
  
-Fixed teleportation bugs   
-Fixed box collider bugs  
-Cleaned up backend code and UI      

V1.2 Changelog  
  
-Added new materials for transparent objects  
-Started work on Medial Lemincus Tract  
-Gained better understanding of layers  
-Able to edit OnTriggerEnter method properly    

        
V1.1 Changelog  
  
-Added Grab support  
-Fixed Right Controller  
-Added ability to slice multiple times  
-To make Blender objects sliceable - check read/write box in property settings    

V1.0 Changelog  
  
-Fixed teleportation bug by linking player to XRorigin rig  
-Added platform above body with teleport point + box collider label  
-Added support for slicing of gameobjects & sword model  
  
V0.4 - V0.7 Changelog  
  
-Worked on teleportation bug  
-Added UI menu to teleport to locations  
  
V0.3 Changelog
  
-Added Human Model  
-Began work on Game Meun Support  
-Built for Oculus Quest 2
  
  
To access through Unity:  
1. Install github desktop and clone this repository  
2. Open project in Unity
3. May have to open scene1 if opened to untitled scene
4. Change build setting according to this (switch platform step only required on a new device one time): https://developer.oculus.com/documentation/unity/unity-build/
5. Make sure Oculus 2 is detected in build settings
6. Build and run
  
  
  
  
Human Model: https://www.cgtrader.com/items/3804914/download-page
