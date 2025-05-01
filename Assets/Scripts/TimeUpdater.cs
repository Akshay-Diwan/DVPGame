using UnityEngine;
using TMPro;
public class TimeUpdater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    TextMeshProUGUI myText;
    bool preComplete = true;
    float preWave = 0;
    bool waveTwo = false;
    EnemySpawner scriptObj; // get this time from the animation
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
        Debug.Log(gameObject.transform.parent.GetChild(1).name);
        scriptObj = gameObject.transform.parent.GetChild(1).GetComponent<EnemySpawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(preComplete == true){
        float timeSinceStart = Time.time; 
        float newWaveIn = 10 - (timeSinceStart - preWave);
        int ms = (int)(newWaveIn * 100) % 100;
        int ss = (int)newWaveIn % 60;
        int mm = (int)newWaveIn / 60;
        if(newWaveIn < 0f){
            waveTwo = true;
            preWave += 10;
        }
        if(waveTwo == true){
            scriptObj.spawnEnemy();
            waveTwo = false;
        }
        myText.text ="Next Wave in " + mm.ToString() +" : " + ss.ToString() + " : " + ms;
        }
        
    }
}
