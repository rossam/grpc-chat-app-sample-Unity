using UnityEngine;
using UnityEngine.UI;

namespace grpc_chat_app.Scripts
{
    public class SwitchToOtherWay : MonoBehaviour
    {
        [SerializeField] private Button switchButton = default!;
        [SerializeField] private GameObject login = default!;
        [SerializeField] private GameObject signIn = default!;

        private void Start()
        {
            switchButton.onClick.AddListener(() =>
            {
                login.gameObject.SetActive(!login.activeSelf);
                signIn.gameObject.SetActive(!signIn.activeSelf);
            });
        }
    }
}
