# Enigma
Enigma machine to solve some challenges.

Now it's just an Enigma M3(german Army and Navy WWII) machine, later I plan to upgrade to also be an M4(U-Boot WWII).

The challenges 1 to 5 I solved by creating a Enigma M3 machine on excel, using VBA.
Challenges 6 to 9, creating an Enigma M3 machine in vb.net.

And now just for the fun of it, I decided to create one in C#.

I created this, to solve a Enigma challenge, where all that is known is the Ciphertext, and the 2 cipherkeys.
Here is the link, to the last challenge: https://www.ciphermachinesandcryptology.com/en/challenge.htm#s10

The whole build up is based upon James J. Gillogly, version on solving a similar problem.
here is the link: https://web.archive.org/web/20060720040135/http://members.fortunecity.com/jpeschel/gillog1.htm

I had 2 choices to solve this, but I thought his way, would make a much more programing experience.
The other choice, would of been, to scan all possibilities of the 1st cypherkey
until the rotors, rotor positions, ring settings and plugs, have created the 2nd cipherkey.
Which then means, that one of these settings should be the right setting, to solve the challange

I analyze the Enciphered new ciphertexts using the Index of Coincidence(IoC), now I'm about to implant into the machine using the plugs, too.
Then I will analyze these new Encipherd texts, with IoC(monogram,bigram, trigram and maybe quadgram), Chi-Squared and some log(not sure which one to use yet).
