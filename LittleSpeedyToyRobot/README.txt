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