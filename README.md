# XML Project "PreciseAim"

## The main goal of the project is to have:
  - A first-person character, which is intractable and can move and make actions as follows:
      - Moving ( with W A S and D keys);
      - Jump ( Space key);
      - Draw an Aim ( M key);
      - Take out an Arrow and aim (N key). If we have taken out an arrow and aim, when we press the "M" key to close the Aim, the arrow is hidden;
      -Shoot with a parabolic movement (K key);
  - Targets (a crate or a barrel attached to a balloon) moving in a room. When the arrow hits the balloon, it disappears and leaves the cargo ( crate or barrel) on the floor as pickable items for the inventory system. The targets are moving until they collide with a wall, then they change direction to the opposite and so on.;
  - A canvas with the player`s health and number of arrows in inventory and if an arrow is being taken out (in the canvas 1/5 means we have taken out an arrow, 0/6 means we have not taken out an arrow);
  - Many of the configurations taken from an XML file: number of targets,  their size, and movement; the number of arrows available;
## Bonus goals:
  - More actions added:
    - Open inventory system (E key);
    - Take item from the ground (R key);
    - Remove item from the inventory to the open world (drag item from inventory system to the side of the system and release);
  - Brand new inventory system:
      - Different slots for different items;
      - Can be recycled and used in other projects because of good implementations;
  - Pickable items:
    - Crates and barrels from the targets;
    - Other small items such as fireballs, normal balls, and sticks;
    - Health for regeneration;
    - Arrows that have been shot.
  ### If you are interested in using the project you can read the following:
    -If you want to add new pickable items just:
      - Create a prefab in "/Resources/Prefabs",
      - Name the prefab as you like, 
      - Change Tag to "Pickable",
      - Import your Inventory image and put it in "/Resources/Inventory2DItems" with the same name as the prefab,
      - that is all.
    -If you want to add more elements through the ".xml" file go to "/Resources/GameElements.xml"
      - You can find different structures, every structure is an item, if you want to make one more items of some structure,
      copy it and change the variables that come with it. There are structures as follows:
        - Torch:
          - Position;
          - Rotation;
          - Scale.
        - Balloon (target):
          - Position;
          - Scale;
          - Speed;
          - Cargo ( can be one of two: Crate or Barrel ( there can be changes, name of cargo must be the same as the name in the prefabs)).
        - Arrows:
          - Position.
        - HealthPotion:
          - Pisition;
          - Ammount.
        
  
