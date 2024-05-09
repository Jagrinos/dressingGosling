using UnityEngine;

public class scriptLexa : MonoBehaviour
{
    // SpriteRenderer spriteRenderer;

    // void Start()
    // {
    //     // Получаем компонент SpriteRenderer объекта
    //     spriteRenderer = GetComponent<SpriteRenderer>();

    //     // Вызываем функцию изменения размера спрайта
    //     Resize();
    // }

    // void Resize()
    // {
    //     if (spriteRenderer == null)
    //     {
    //         Debug.LogError("SpriteRenderer component not found!");
    //         return;
    //     }

    //     // Получаем размеры экрана
    //     float screenHeight = Camera.main.orthographicSize * 2f;
    //     float screenWidth = screenHeight * Screen.width / Screen.height;

    //     // Получаем размеры спрайта
    //     float spriteHeight = spriteRenderer.sprite.bounds.size.y;
    //     float spriteWidth = spriteRenderer.sprite.bounds.size.x;

    //     // Рассчитываем необходимый масштаб для спрайта
    //     float scaleX = screenWidth / spriteWidth;
    //     float scaleY = screenHeight / spriteHeight;

    //     // Выбираем меньшее значение для обеспечения правильного масштабирования
    //     float scale = Mathf.Min(scaleX, scaleY);

    //     // Применяем масштаб к спрайту
    //     transform.localScale = new Vector3(scale, scale, 1f);
    // }
}
