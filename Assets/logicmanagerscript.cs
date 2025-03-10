using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanagerscript : MonoBehaviour
{
   public int playerscore;
   public Text scoretext;
   public GameObject gameoverscreen;
   [ContextMenu("Increase Score")]
   public void addscore(int scoreToAdd){
    playerscore+=scoreToAdd;
    scoretext.text=playerscore.ToString();
   }
   public void restartgame(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void gameover(){
     gameoverscreen.SetActive(true);
   }
}
