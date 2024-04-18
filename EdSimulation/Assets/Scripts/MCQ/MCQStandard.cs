using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MCQ
{
    public class McqStandard : MonoBehaviour
    {

        [SerializeField]private TMP_Text headingText;
        [SerializeField]private TMP_Text questionText;
        [SerializeField]private TMP_Text option1;
        [SerializeField]private TMP_Text option2;
        [SerializeField]private TMP_Text option3;
        [SerializeField]private TMP_Text option4;
        
        [SerializeField]private Button bOption1;
        [SerializeField]private Button bOption2;
        [SerializeField]private Button bOption3;
        [SerializeField]private Button bOption4;

        private void OnEnable()
        {
            bOption1.onClick.AddListener(OnOption1);
            bOption2.onClick.AddListener(OnOption2);
            bOption3.onClick.AddListener(OnOption3);
            bOption4.onClick.AddListener(OnOption4);
        }

        public void SetMcqValues(string q,
            string o1,
            string o2,
            string o3,
            string o4,
            string h = "Please select the correct option")
        {
            headingText.text = h;
            questionText.text = q;
            option1.text = o1;
            option2.text = o2;
            option3.text = o3;
            option4.text = o4;
        }

        private void OnOption1()
        {
            // todo: Button Click Logic
        }
        private void OnOption2()
        {
            // todo: Button Click Logic
        }
        private void OnOption3()
        {
            // todo: Button Click Logic
        }
        private void OnOption4()
        {
            // todo: Button Click Logic
        }
        
        
        
    }
}
