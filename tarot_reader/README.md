# Tarot Reading Program

## What it does

Allows user to choose between one-, three-, and five-card reading.

print "Would you like to explore your theme for the day (1), receive advice about a problem (3) or explore a relationship (5)?"

Input will be saved to a variable that will relate to a particular number of cards.

User will enter one of these numbers only. Other numbers will return "Please select 1, 3 or 5 to receive your reading."
* One-card readings are daily readings giving the user an overall theme for their day.
* Three-card readings are for situation | obstacle | advice
* Five-card readings are for your role in the relationship | partner's role in the relationship | past foundation | current state | near future

When user input is received, user will be prompted to think about their question and input S when ready to shuffle and deal.

When S is pressed, computer will say "Shuffling . . . "

Then after a short delay, the face down card(s) will print to the console.

User will be prompted to press N to turn over a card (loops if need to turn over more than one?)

When a card turns over, it will appear with print out of the card name and properties description

If there are more cards, user will be prompted again to turn them over.

After reading is complete, user will be asked if they want another reading. If Y, start over. If N, exit.

## What I Need
* classes with card properties set up
* shuffle method (located in deck class?)
* start face down
* flip method (one at a time, triggered by readkey?)
    * when flipped, card should show properties
* figure out how to format cards in console for visual, if possible
* figure out how to pause between line printing if printing multiple lines
* figure out how to repeat program starting with the reading input if user wants to do it again.
* try catch for user input to ensure they enter usable response to questions


### Look up
* Pausing the program to take a second or two to print the next thing so it doesn't all appear at once.
* how to print card properties to the console
* how to make cards start face down then flip up one at a time
* how to print art for face down and face up cards
* how to print art for card spreads



### Class - Major Arcana
* includes 0 - 21 named cards with specific related information (write properties)
    * 0	- The Fool
    * 1	- The Magician
    * 2	- The High Priestess
    * 3	- The Empress
    * 4	- The Emperor
    * 5	- The Hierophant
    * 6	- The Lovers
    * 7	- The Chariot
    * 8	- Justice
    * 9	- The Hermit
    * 10 - Wheel of Fortune
    * 11 - Strength
    * 12 - The Hanged Man
    * 13 - Death
    * 14 - Temperance
    * 15 - The Devil
    * 16 - The Tower
    * 17 - The Star
    * 18 - The Moon
    * 19 - The Sun
    * 20 - Judgement
    * 21 - The World

### Classes - Minor Arcana
* includes numbers & face cards: Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Page, Knight, Queen, King
    * Wands
        * Clubs / Fire / Artisans / Creativity and will
    * Cups
        * Hearts / Water / Clergy / Emotions and love
    * Swords
        * Spades / Air / Nobility and military / Reason
    * Pentacles
        * Diamonds / Earth / Merchants / Material body or possessions
    





