using UnityEngine;

/// <summary>
/// SquareObject - Lớp đại diện cho một ô vuông trong hệ thống Unity.
/// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
/// </summary>
public class SquareObject : MonoBehaviour
{
    #region --- Unity Methods ---

    void Start()
    {
        SetSpriteComponent();
    }

    #endregion

    #region --- Methods ---

    /// <summary>
    /// Lấy component SpriteRenderer từ ô vuông.
    /// </summary>
    private void SetSpriteComponent()
    {
        _squareSprite = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Hiện/ẩn ô vuông dựa trên trạng thái hiện tại của nó.
    /// </summary>
    public void ToggleVision()
    {
        if (_isShowOn)
        {
            _isShowOn = false;
            gameObject.SetActive(true);
        }
        else
        {
            _isShowOn = true;
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Đặt màu ngẫu nhiên cho ô vuông.
    /// </summary>
    public void SetRandomSquareColor()
    {
        Color rndColor = Random.ColorHSV(0f, 1f, 0.5f, 1f, 0.5f, 1f);
        _squareSprite.color = rndColor;
    }

    /// <summary>
    /// Đặt màu cụ thể cho ô vuông.
    /// </summary>
    /// <param name="color">Màu của ô vuông.</param>
    public void SetSquareColor(Color color)
    {
        _squareSprite.color = color;
    }

    #endregion

    #region --- Properties ---



    #endregion

    #region --- Fields ---

    [SerializeField] private SpriteRenderer _squareSprite;

    private bool _isShowOn = false;

    #endregion
}
