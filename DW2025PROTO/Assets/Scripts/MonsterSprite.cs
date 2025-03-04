using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterSprite : MonoBehaviour
{
    Image image;
    public List<Sprite> sprites;
    public float animaSpeed;
    int curSprite;
    float animaTimer;
    void Start()
    {
        image = GetComponentInChildren<Image>();
        curSprite = 0;
        animaTimer = animaSpeed;
        image.sprite = sprites[curSprite];
    }
    void Update()
    {
        animaTimer -= Time.deltaTime;
        if (animaTimer <= 0) { curSprite++; animaTimer = animaSpeed; }
        if(curSprite >= sprites.Count) { curSprite = 0; }
        image.sprite = sprites[curSprite];
    }
}
