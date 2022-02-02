# jlangl-assignment1-minigame

Unity mini-game made using basic knowledge of scripts, rigid bodies and colliders.

Specifications:
 1. Player:
• The player rolls the ball within the box by pressing the arrow keys.
• The ball must behave as if it is pushed.
• When the ball hits the wall of the arena, it should bounce back as a real ball rolled
against the wall.
• The ball must remain in the box and not bounce out of the box. The wall height must
remain reasonably low to enable a full view of the playing area.
• The game layout/arena and pickup objects must look different than what is shown in
the assignment

2. Pickup objects:
• Eight or more pickup objects (cubes in the figure) must be located just above the box.
• There should be at least three types of pickup objects that look different. For example,
maybe there are four square pickup objects, two cubes, and two cylinders.
• All pickup objects should be created dynamically (cannot start the game with pickup
objects in place).
• There should only be one or a very few pickup assets in the project (less than the
number of the pickup objects in the game).

3. Picking up objects:
• When the ball hits a pickup object, the pickup object must disappear, and the score
must increase. Display the score in the upper right corner.
• Pickup objects that look different must result in different point gains and all that look
the same must result in the same number of points.
• When there are no more pickups, the game should pause for a few seconds and then
restart.
• The score should be displayed in the right-upper corner of the game and maintain the
same location when the game window is resized.
