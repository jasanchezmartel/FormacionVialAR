using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using Vuforia;

public class VideoTargetHandler : MonoBehaviour {
    public VideoPlayer videoPlayer;
    public GameObject panelBotones;
    public string escenaSalida = "MainMenu";

    private ObserverBehaviour observer;
    private bool terminado = false;

    void Start() {
        observer = GetComponent<ObserverBehaviour>();
        observer.OnTargetStatusChanged += OnStatusChanged;

        videoPlayer.isLooping = false;
        videoPlayer.loopPointReached += OnVideoTerminado;

        panelBotones.SetActive(false);
    }

    void OnDestroy() {
        if (observer != null)
            observer.OnTargetStatusChanged -= OnStatusChanged;
        if (videoPlayer != null)
            videoPlayer.loopPointReached -= OnVideoTerminado;
    }

    void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status) {
        if (terminado) return;

        bool visible = status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED;

        if (visible) videoPlayer.Play();
        else videoPlayer.Pause();
    }

    void OnVideoTerminado(VideoPlayer vp) {
        terminado = true;
        panelBotones.SetActive(true);
    }

    public void Repetir() {
        terminado = false;
        panelBotones.SetActive(false);
        videoPlayer.time = 0;
        videoPlayer.Play();
    }

    public void Salir() {
        SceneManager.LoadScene(escenaSalida);
    }
}