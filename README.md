# CardDeck
C# Generated Card deck and random draw

## Program Class
### Main()
* Deck.CreateDeck() //Create the deck
* Deck.DrawCards() // takes an int and draws n cards

## Card Class
* Defines the Card and its properties.
* Logic within the constructor assigns face values Ace, Jack, Queen, King
* Logic to assign color based on Suit (seems superfluous for now but might come in handy later
* ToSting() overide alters the retuned value depending on face or number card

## Deck Class
### CreateDeck()
* Programatically generates the deck by suit and card value
* Stores cards in an array of type Card

### DrawCards(int numOfCards)
* Creates a temp list to store previously generated random numbers
* Generates a Random number and checks it agains the list
* A while loop genarates new random numbers until a number not already in the list is generated
* The Generated number is added to the list of past numbers 
* the generated number is used to call a card from the deck based on the array index.
