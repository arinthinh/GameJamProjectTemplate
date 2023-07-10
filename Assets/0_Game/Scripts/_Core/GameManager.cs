using Cysharp.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake() => DontDestroyOnLoad(this);
    private void Start() => InitGame().Forget();

    public async UniTask InitGame()
    {
        await UniTask.Yield();
        Debug.Log("Init game complete");
        SceneLoader.Instance.LoadScene(SceneName.GAME).Forget();
    }
}