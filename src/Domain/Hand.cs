namespace Domain;

public class Hand
{
    public IEnumerable<BlackJackCard> Cards {get;}
    public int NrOfCards {get;}
    public int Value {get;}
    private IList<BlackJackCard> _cards;

    public Hand()
    {
        throw new NotImplementedException(); 
    }

    public void AddCard(BlackJackCard card)
    {
        throw new NotImplementedException(); 
    }

    public void TurnAllCardsFaceUp()
    {
        throw new NotImplementedException(); 
    }

    private int CalculateValue()
    {
        throw new NotImplementedException(); 
    }
}