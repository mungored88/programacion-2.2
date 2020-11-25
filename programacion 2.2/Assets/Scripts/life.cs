using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    public int Life;
    public int NumberOfHeart;
    public Image[] hearts;
    public Sprite fulHeart;
    public Sprite emptyHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Life > NumberOfHeart)
        {
            Life = NumberOfHeart;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Life)
            {
                hearts[i].sprite = fulHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < NumberOfHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (Life <= 0)
        {
            //Die();
        }
    }
    public void TakeDamage(int damage)
    {
        Life -= damage;
        if (Life <= 0)
        {
            Die();
        }
    }
    void Die()
    {
       GameObject.Destroy(this.gameObject);
       SceneManager.LoadScene("lost");
    }
}
