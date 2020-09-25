public class DiscordGenerators {
    UIID partySecret = new UIID();
    UIID matchSecret = new UIID();
    UIID spectateSecret = new UIID();
    public DiscordGenerators(){
        generate();
    }
    private void generate(){

    }
    public UIID getPartySecret(){
        return this.partySecret;
    }
    public UIID getMatchSecret(){
        return this.matchSecret;
    }
    public UIID getSpectateSecret(){
        return this.spectateSecret;
    }
}