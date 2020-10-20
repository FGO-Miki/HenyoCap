using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void MatsingPagong()
    {
        SceneManager.LoadScene("MatsingPagong");
    }

    // Update is called once per frame
    public void AlamatNgPinya()
    {
        SceneManager.LoadScene("AlamatNgPinya");
    }
}
