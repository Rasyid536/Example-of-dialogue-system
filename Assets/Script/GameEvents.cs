using UnityEngine;
using System.Collections;


public class GameEvents : MonoBehaviour
{
    public GameObject[] Pict;
    public int[] matcher;
    private int indexs;
    private int indexer;
    public Dialogue dialogue;
    public GameObject component, componentOne, mother;

    void Start()
    {
        UpdateActiveGameObject(); // Panggil fungsi saat awal permainan
        indexer = 1;
    }

    void EventMatcher()
    {
        if(dialogue.index > 0)
        {
            if(matcher[indexer] == dialogue.index)
            {
                indexs++;
                indexer++;
            }
        }
    }

    void Update()
    {
        // Ubah index dengan tombol angka (opsional)
        UpdateActiveGameObject();
        EventMatcher();
        Mother();
    }

    // Fungsi untuk memperbarui GameObject yang aktif
    void UpdateActiveGameObject()
    {
        for (int i = 0; i < Pict.Length; i++)
        {
            if (Pict[i] != null)
            {
                // Aktifkan GameObject jika index sama
                Pict[i].SetActive(i == indexs);
            }
        }
        if(dialogue.index == 163)
        {
            component.SetActive(true);

        }
        else
        {
            component.SetActive(false);
        }
        if(dialogue.index == 164 || dialogue.index == 165)
        {
            componentOne.SetActive(true);
        }
        else
        {
            componentOne.SetActive(false);
        }

    }

    void Mother()
    {
        if(dialogue.index == 13 && dialogue.textComponent.text.Length >= 75)
        {
            mother.SetActive(true);
        }
        else if(dialogue.index == 14)
        {
            mother.SetActive(false);
        }

        if(dialogue.index == 99 && dialogue.textComponent.text.Length >= 83)
        {
            mother.SetActive(true);
        }
        else if(dialogue.index == 100)
        {
            mother.SetActive(false);
        }
    }
    
}
