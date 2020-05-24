# Game Engines Project 2

## Description:

Sci Fi battle between humans and aliens as seen in Mass Effect. 

https://www.youtube.com/watch?v=HlLS5w_DQGc&t=1m19s

Premise: The Destiny Ascension, an friendly alien flagship is under fire and the human alliance fleet is coming in to save them

Storyboards 

Scene 1
![Scene1](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/1.png)

Still camera shot of Mass relay, facing towards incoming ships

Scene 2
![Scene2](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/2.png)

Ships warp in towards camera but slow down as they get closer

Scene 3
![Scene3](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/3.png)

Camera moves to the side and sweeps around keeping lead ship in frame

Scene  4
![Scene4](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/4.png)

Lead ship picks up speed and moves out of view forward while the rest of the ships follow

Scene 5
![Scene5](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/5.png)

Shot of friendly ship, the Destiny Ascension getting hit with enemy fire

Scene 6
![Scene6](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/6.png)

Cut back to Alliance fleet, they open fire past the camera

Scene 7
![Scene7](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/7.png)

Chaos begins, ships shoot and dogfight with each other

Scene 8
![Scene8](https://github.com/OisinR/Game-Engines-Project-2/blob/master/GE2Assignment/8.png)

Day is saved, Destiny Ascension is safe and enemy is destroyed



## Instructions:

Just start it up, it runs by itself.


## How it works:

Setup scenes work by using arrive behaviours, main battle works by having a combination of pursue, path following and flee behaviours as well as obstacle avoidance. Ships will pursue the main enemy, shooting at them when they're in front of them. When they get too close, they then turn to flee so they can line themselves up for another bombing run. The path around the enemy encourages ships to move around the enemy, rather than just fly towards and away from them in the same spot. When the first enemy has taken enough damage, the second enemy is destroyed and the first enemy is moved to the second enemy's position. Its health is reset and all ships go and take it out again. The reason I did it this way is so I don't have to re-setup all the steering behaviours on the second ship, they all just persist from the first time.

## What I am most proud of in the assignment:

The first scene looks quite close to the original and I really like the "warping in" effects.


## Scripts:

From class:
SteeringBehaviour,
Pursue,
Path,
OffsetPursue,
ObstacleAvoidance,
FollowPath,
Flee,
Boid,
Arrive

All others are from me


## Links to assets used:

https://www.thingiverse.com/thing:1978056

https://free3d.com/3d-model/ssv-normandy-sr1-mass-effect-92431.html

https://free3d.com/3d-model/human-fighter-sx1-mass-effect-92178.html

https://www.thingiverse.com/thing:702830

https://www.thingiverse.com/thing:3462541

http://www.mediafire.com/file/x6sua6mjyd41yu4/GethDreadOBJ.rar/file

https://www.thingiverse.com/thing:2196446

https://sketchfab.com/alinebslv/collections/mass-effect

https://www.thingiverse.com/thing:69086

http://www.mediafire.com/file/9y9hoy0jz57d0yv/Normandy2OBJ.rar/file

https://opengameart.org/content/63-digital-sound-effects-lasers-phasers-space-etc

https://anttimartikainen.bandcamp.com/album/the-last-chronicle
