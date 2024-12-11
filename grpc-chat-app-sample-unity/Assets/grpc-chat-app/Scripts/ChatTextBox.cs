using TMPro;
using UnityEngine;

namespace grpc_chat_app.Scripts
{
    public class ChatTextBox : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text = default!;
        
        public void SetText(string text)
        {
            _text.text = text;
        }
    }
}