namespace Domain;

public class BlackJack
{
    public const bool FaceDown = false;
    public const bool FaceUp = true;
    public GameState GameState {get; private set;}
    private Deck _deck;
    public Hand PlayerHand {get;}
    public Hand DealerHand {get;}

    public BlackJack()
    {
        throw new NotImplementedException(); 
    }

    public BlackJack(Deck deck)
    {
        throw new NotImplementedException(); 
    }

    private void Deal()
    {
        throw new NotImplementedException(); 
    }

    public void PassToDealer()
    {
        throw new NotImplementedException(); 
    }

    public string GameSummary()
    {

    }

    public void GivePlayerAnotherCard()
    {
        throw new NotImplementedException(); 
    }

    private void AddCardToHand(Hand hand, bool FaceUp)
    {
        throw new NotImplementedException(); 
    }

    private void AdjustGameState(GameState gameState = null)
    {
        throw new NotImplementedException(); 
    }

    private void LetDealerFinalize()
    {
        throw new NotImplementedException(); 
    }

}