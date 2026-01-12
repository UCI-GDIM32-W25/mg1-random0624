[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Ransom Liu, he/him

In my breakdown document, the objects I mentioned were implemented in the homework. Some of them, like green background, has already been implemented. What I had to do was adding the seed asset, player movement, and a scoring system using tmp_text. 

I implemented the seed planting mechanism with Instantiate. _plantPrefab is the gameobject being cloned, _playerTransform.position gets the player's current position, and _playerTransform.forward gets the direction the player is facing.

For the cat's player movement, I referenced what we did back in GDIM31. First, because movement input is captured every frame, it has to be in the Update() method. Input.axis gets the keyboard input (horizontal for A/D and left/right, and vertical for W/S and up/down). Then, we instantiate a new instance of a vector that takes horizontal and vertical movement as input, *speed, and *Time.deltaTime so movement speed isn't frame dependent. Finally we translate the player's Transform instance to make it move.

Text updates are implemented in PlantCountUI class. There are two pieces of ui in canvas. We create an UpdateSeed() method that is called everytime Space is pressed. This is when the PlantSeed() method updates the planted and remaining numbers, and sends it back to UpdateSeed(). 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
