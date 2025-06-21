using DesignParttern.Interfaces.Command;
using UnityEngine;

/// <summary>
/// ChangeColorCommand - Lớp lệnh để chuyển đổi màu sắc của một ô vuông trong hệ thống Unity.
/// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
/// </summary>
public class ChangeColorCommand : ICommand
{
    #region --- Methods ---

    /// <summary>
    /// Constructor - Khởi tạo lệnh để chuyển đổi tầm nhìn của một ô vuông.
    /// </summary>
    /// <param name="square">Script đối tượng hình vuông</param>
    public ChangeColorCommand(SquareObject square)
    {
        _square = square;
        _previousColor = square.GetComponent<SpriteRenderer>().color;
    }

    /// <summary>
    /// Thực hiện lệnh để chuyển đổi màu của ô vuông.
    /// </summary>
    public void Execute()
    {
        _square.SetRandomSquareColor();
    }

    /// <summary>
    /// Hoàn tác lệnh để chuyển đổi lại màu của ô vuông về trạng thái trước đó.
    /// </summary>
    public void Undo()
    {
        _square.SetSquareColor(_previousColor);
    }

    #endregion

    #region --- Fields ---

    private SquareObject _square;
    private Color _previousColor;

    #endregion
}
