using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool DebugStart { get; private set; } = false;

    public int StageID { get; private set; } = 0;
    public StageList Stages { get; private set; }

    private void Awake()
    {
        Stages = gameObject.transform.GetComponent<StageList>();

#if UNITY_EDITOR
        // 既にステージシーンがあればデバッグ起動(現状、複数判定) 
        DebugStart = SceneManager.sceneCount > 1;

        // デバッグ起動の場合ステージ読込をスキップ
        if(DebugStart)
        {
            return;
        }
#endif
        SceneManager.LoadScene(Stages.GetStageName(StageID), LoadSceneMode.Additive);
    }

    public void ChangeNextStage()
    {
        var old_stage = Stages.GetStageName(StageID);
        var next_stage = Stages.GetStageName(++StageID);

        SceneManager.LoadScene(next_stage, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(old_stage);
    }
}
