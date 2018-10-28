This is a small .Net Core app simulating the movements of Little Speedy, the Toy Robot!
Choosing .Net Core 2.1 is a sensible option as it is declared as LTS by Microsoft.

His mission on this world is to move around on a table without falling over. 
(although he is pretty sure that lots of humans will actively try to make him fall over said table, Lemmings-style)

Any commands that will instruct Little Speedy to fall over the table will result in him ignoring the command.
Commands that are acceptable by Speedy include:
PLACE  (place Speedy somewhere on the surface)
MOVE   (Speedy moves forward)
LEFT   (Speedy makes a 90 degrees left rotation)
RIGHT  (Speedy makes a 90 degrees right rotation)
REPORT (Speedy reports his position, quite possibly looking at you with disbelief because you will attempt multiple times to make him dive off the table)

An image of Little Speedy is also included for reference. Has a bit of a Doctor Who-ish Daleky aura, doesn't it?

P.S. (Further ideas down the line: A beautiful next step would be exposing this functionality as an (AWS??) API (AWS because Alexa skills integrate easily with them), 
referencing that with an Alexa Skill, and using Alexa's Echo buttons + voice to invoke these commands? Definitely fun for playing with a group of friends for example)


==>NOTES ON THE CODE AND IMPLEMENTATION<==

Time I spent on the code:
A total of about 4 hours

Notes on the code / implementation decisions: 
As you can see, my intention was to abstract away as much of the "Common Sense" logic into a Common project, with methods
that could be Unit Tested as well. In this case I chose not to go about Unit Testing the "Helpers" at this point to allow me to focus on the actually important classes.

I have abstracted away the table dimensions in a static class there to simulate it being stored somewhere 
(DB, configuration, environment variable) rather than hardcoding it into the "Speedy" class itself. After all, Speedy does NOT have to know
about the table dimensions, it only needs to know how to avoid a fall. 

(Extension/added point) Also as you can see, I added a bonus "Mood" enum, which given a bit more time
I can use to increase and descrease Speedy's mood, according to if the user is attempting to drop him off the table or not! Makes for a fun element.

For the Unit Tests I tried to use as much input data and detailed testing methodology as possible in the given time limit. 
My "weapon of choice" for writing Unit Tests was and will always be NUnit, but I just used xUnit in this case to try it out.
In a real world scenario, any dependencies that the Speedy class might have would be mocked (As you can see I have already added the Moq Nuget package)
Lastly, a good thing to notice would be that I abstracted away all of Speedy's methods, thus facilitating the writing of Unit Tests,
and how I have implemented all of Speedy's properties as Public Getters, Private Setters

Lastly, notice how I have added a few extension points, like optional parameters to the Move() and Left() / Right() methods to allow for
extended functionality (making more than one steps, or turning more times by using one command). 
Given more time I could also utilize them, by first incorporating them into the Unit Tests, 
and then proceeding into altering Speedy's concrete implementation as well (sticking to clean TDD methodology)

Final point to note:
The standard-input functionality has NOT been implemented at this point (just the start of it has been crudely implemented), so one could call this task formally NOT complete.
HOWEVER, I have chosen to focus my time into building the code and the associated Unit Tests.

In a real world scenario, the next steps I would take are the following:
1) Create an interface for a class that plays with Speedy. This would do the job of reading from standard input or user keyboard input, and invoking Speedy's commands.
2) I would write Unit Tests for it, ensuring correct behaviour, like for example, for a user to play with Speedy, he should be placed first.
3) Ensure that everything is properly injected into the required classes, rather than just being "newed" up. So, in this class's case, Speedy could be injected,
using .Net Core's implicit Dependency injection mechanism, by adding the appropriate code in the 'Configure' / 'ConfigureServices' methods

My ambition at this point was, given my limited time, to provide the reviewer with a piece of code that demonstrates the implementor's tendency towards modular, 
scalable, both testable and well tested code. 
Instead of me spending time on implementing "reading from keyboard input" functionality, I decided to provide the reviewer with an idea of my way of thinking, 
and a set of as meaningful as possible Unit Tests. Also take note that at the time of writing this, ALL of the Unit Tests were running successfully