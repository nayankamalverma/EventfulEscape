using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int keyRequiredToTrigger;
    [SerializeField] private SoundType soundType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>()!= null && keyRequiredToTrigger == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundType);
            GetComponent<Collider>().enabled = false;
        }
    }
}