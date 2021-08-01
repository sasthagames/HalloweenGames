using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
//using Newtonsoft.Json;
using UnityEngine.UI;
using System;
public class PlayFabManager : MonoBehaviour
{
	public static PlayFabManager instance;
	public GameObject rowprefab;
	public Transform rowsParent;
	[Header ("Windows")]
	public GameObject nameWindow;
	public GameObject leaderBoardWindow;
	[Header ("Display name Window")]
	public GameObject nameError;
	public Text Input_nickname;
	
		private void Awake()
	{
		instance = this;
	}

    // Start is called before the first frame update
    void Start()
    {
		
    Login();
    }
	
	
	void Login()
	{
		var request = new LoginWithCustomIDRequest 
		{
	//	CustomId = SystemInfo.deviceUniqueIdentifier, //Old
		CustomId = "Tutorial",
		CreateAccount = true,
		InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
			{
				GetPlayerProfile = true
			}
		};
		PlayFabClientAPI.LoginWithCustomID(request,OnLoginSucess,OnPlayFabError);
	}
	void OnLoginSucess(LoginResult result)
	{
		Debug.Log("Successfully login/account create!");
				string name = null;
		if(result.InfoResultPayload.PlayerProfile != null)
		
	name = result.InfoResultPayload.PlayerProfile.DisplayName;
		
		if(name == null )
		
		nameWindow.SetActive(true);
		
		else
			leaderBoardWindow.SetActive(true);
		
	}
	
	public void SendLeaderBoard(int score)
	{
		var request = new UpdatePlayerStatisticsRequest{
			Statistics  = new List<StatisticUpdate>{
				new StatisticUpdate{
					StatisticName = "PlayerScore",
					Value = score
				}
			}
		};
		PlayFabClientAPI.UpdatePlayerStatistics(request,OnLeaderboardUpdate,OnPlayFabError);
			 
	}
	void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)	{
	//	Debug.Log ("CSuccesful leaderboard Send!!");
	}
	public void GetLeaderboard()
	{
		var request = new GetLeaderboardRequest{
		StatisticName = "PlayerScore",
		StartPosition = 0,
		MaxResultsCount = 10
	};
	PlayFabClientAPI.GetLeaderboard(request,OnLeaderboardGet,OnPlayFabError);
	}
	
/*	public void SubmitNameButtonBehievior()
	{
		string text = Input_nickname.text;
		if(text != "")
		{
			var request = new UpdateUserTitleDisplayNameRequest();
			
			request.DisplayName = text;
			
			PlayFabClientAPI.UpdateUserTitleDisplayName(request,OnDisplayNameUpdate,OnPlayFabError);
		}
	}
	*/
	
	public void SubmitNameButton()
	
	{		
 
		 var request = new UpdateUserTitleDisplayNameRequest 
		 {            
			DisplayName = Input_nickname.text,
			
		 };
	//	PlayFabClientAPI.UpdateUserTitleDisplayName(request,OnDisplayNameUpdate,OnPlayFabError);
	//		PlayFabClientAPI.UpdateUserTitleDisplayName(request,OnDisplayNameUpdate,OnError);
	}
	
/*	public void SubmitNameButtonBehievior()
	
	{		
		 var req = new UpdateUserTitleDisplayNameRequest 
		 {            
			DisplayName = Input_nickname.text,
		 };
	//	PlayFabClientAPI.UpdateUserTitleDisplayName(request,OnDisplayNameUpdate,OnError);
		PlayFabClientAPI.UpdateUserTitleDisplayName(req,OnDisplayNameUpdate,res=>{
		Debug.Log($"sucess!! playername:{res.DisplayName}");
	},err=> {
		Debug.Log(err.GenerateErrorReport());
	});
	
	}
*/
	private void OnPlayerNameResult(UpdateUserTitleDisplayNameRequest obj)
	
	{
		
		print ("player name "+ obj.DisplayName);
		
	}
	void OnDisplayNameUpdate(UpdateUserTitleDisplayNameRequest result)
	{
		Debug.Log("Updated Display name!");
		leaderBoardWindow.SetActive(true);
	}
	 void OnPlayFabError(PlayFabError error)
        {
            Debug.Log($"{error.Error}");
        }
	
	void OnLeaderboardGet(GetLeaderboardResult result)	
	{
		foreach(Transform item in rowsParent)
		{
			Destroy(item.gameObject);
		}
			
		foreach(var item in result.Leaderboard)
		{
			GameObject newGo = Instantiate(rowprefab,rowsParent);
			Text[] texts = newGo.GetComponentsInChildren<Text>();
			texts[0].text = (item.Position + 1).ToString();
			texts[1].text = item.DisplayName;
			texts[2].text = item.StatValue.ToString();
			Debug.Log(string.Format("Place:{0} | ID: {1} | VALUE: {2}",
			item.Position,item.PlayFabId,item.StatValue));
			Debug.Log (item.Position + "" + item.PlayFabId + "" + item.StatValue);
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
