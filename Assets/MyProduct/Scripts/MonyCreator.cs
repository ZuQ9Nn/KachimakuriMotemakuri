using UnityEngine;

using HoloToolkit.Unity.InputModule;

public class MonyCreator : MonoBehaviour, IInputClickHandler
{
    [SerializeField]
    private int MaxCount = 100;

    [SerializeField]
    private GameObject moneny = null;

    // Use this for initialization
    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (moneny)
        {
            for(int i = 0; i < MaxCount; i++)
            {
                Instantiate(moneny, GazeManager.Instance.HitPosition, Quaternion.identity);
            }
        }
    }
}
