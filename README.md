# Dimension Dissension

- This game takes you through multiple dimemsions to help get rid of creatures that have been taking over that area. You are given multiple quests to choose from each time you enter a dimension. You can choose one, but be careful, the better the item, the harder the quest will be. The fourth dimension you visit will be a boss fight and the end of the game for now.

## Screenshots
![mainmenu](https://user-images.githubusercontent.com/53247675/213339033-7db54dcf-87d9-4a1d-9a55-3bf8990622ce.PNG)

More screenshots to come!

## Built With

* [Unity](www.unity.com)

## Game Design

- Dimension Dissension was first conceptualized as a 2D platformer roguelike, similar to the game Risk of Rain, but with RPG elements like stats for the player and a quest system. During development, I realized that I had overscoped the project and what I originally had in mind would take me far longer to accomplish than what I wanted to spend on this project. I decided to cut a lot of ideas and focus on the big thing I wanted the game to revolve around, Quests. I also changed the PoV from a side scroller, to a top down 'shooter' game where you play as a mage.

## Programming
- During my dive into learning about the SOLID principles, I came across C# Interfaces for the first time. I had a hard time understanding them at first, but the best way for me to fully grasp something is to teach someone else, so I like to write a post about the concept as if I were teaching someone, or reminding my future self. After talking to some very helpful people from a discord I'm a part of, I mananged to understand why they are so awesome.
- I realize that I can use interfaces to essentially 'type' gameObjects. Instead of checking for a tag, which can be very slow, I can now check to see if a gameObject has the component of the interface name. I can do this when there is a collision, to detect whether or not the player has collided with any enemy that has the IIsEnemy interface like this.
```
C#
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsEnemy enemy = collision.gameObject.GetComponent<IsEnemy>();

        if (enemy != null)
            TakeDamage();
    }
}
```

## Art
- Since I am not well versed in the ways of art, I am using multiple asset packs to give the effect that the player is traveling through multiple dimensions
- Check out the asset pack Tiny Dungeon [here](https://www.kenney.nl/assets/tiny-dungeon)

## Sound
- I don't have any sound in the game just yet, but I have just as much skill creating music and sound as I do with art so check out the assets I've used later here

## Things I've Learned

- Failing to Plan is Planning to Fail
- Tilemaps Exist! (I spent hours moving each tile before I realized this existed :D )
- Proper Conventions ( I learned this during development, but these are things I will continue to practice each time I code )
  - SOLID Principles
  - I thought camelCase was meant for all variables regardless, but I learned that PascalCase is meant for public variables, and I can use _camelCase for private variables.
- Don't get caught up in the little things when first prototyping things. I got stuck on getting animations to work on the first level I made when combat wasn't even working properly, and I ended up scrapping animations all together. Lesson learned.
- C# Interfaces
