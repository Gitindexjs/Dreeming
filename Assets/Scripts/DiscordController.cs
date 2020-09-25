using UnityEngine;
using System;
public class DiscordController : MonoBehaviour {
	private Discord.Discord discord;
	void Start () {
        DiscordGenerators uiids = new DiscordGenerators();
        UIID partySecret = uiids.getPartySecret();
        UIID matchSecret = uiids.getMatchSecret();
        UIID spectateSecret = uiids.getSpectateSecret();
		discord = new Discord.Discord(756885699059253378, (UInt64) Discord.CreateFlags.Default);
		var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
		{
			State = "Playing Dreeming",
            Details = "Making their Dreem",
            Timestamps = {
                Start = Convert.ToInt64(Constants.startEpocDate),
            },
            Assets = {
                LargeImage = "dreembig",
                LargeText = "Dreem Logo",
                SmallImage = "dreemsmall",
                SmallText = "Making their Dreem",
            },
            Party = {
                Id = new UIID().ToString(),
                Size = {
                    CurrentSize = 1,
                    MaxSize = 4,
                },
            },
            Secrets = {
                    Match = matchSecret.getVal(),
                    Join = partySecret.getVal(),
                    Spectate = spectateSecret.getVal()
            },
            Instance = true,
		};
		activityManager.UpdateActivity(activity, (res) =>
		{
			if (res == Discord.Result.Ok)
			{
				Debug.Log("Discord RPC running perfectly.");
			}
		});
	}
	void Update () {
		discord.RunCallbacks();
	}
    private void OnDisable() {
        discord.Dispose();
    }
}