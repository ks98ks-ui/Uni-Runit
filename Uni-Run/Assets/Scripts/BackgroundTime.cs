using UnityEngine;

public class BackgroundTime : MonoBehaviour
{
    public SpriteRenderer[] backgrounds;
    public Sprite[] timeSprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgrounds[0].sprite = timeSprites[0];
        backgrounds[1].sprite = timeSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time / 15) % 4;

        backgrounds[0].sprite = timeSprites[index];
        backgrounds[1].sprite = timeSprites[index];

    }
}
