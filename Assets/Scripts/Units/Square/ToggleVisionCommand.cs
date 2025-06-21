using DesignParttern.Interfaces.Command;
using UnityEngine;

/// <summary>
/// ToggleVisionCommand - Lớp lệnh để chuyển đổi tầm nhìn của một ô vuông trong hệ thống Unity.
/// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
/// </summary>
public class ToggleVisionCommand : ICommand
{
    #region --- Methods ---

    /// <summary>
    /// Constructor - Khởi tạo lệnh để chuyển đổi tầm nhìn của một ô vuông.
    /// </summary>
    /// <param name="square"></param>
    public ToggleVisionCommand(SquareObject square)
    {
        _square = square;
    }

    /// <summary>
    /// Thực hiện lệnh để chuyển đổi tầm nhìn của ô vuông.
    /// </summary>
    public void Execute()
    {
        _square.ToggleVision();
    }

    /// <summary>
    /// Hoàn tác lệnh để chuyển đổi lại tầm nhìn của ô vuông về trạng thái trước đó.
    /// </summary>
    public void Undo()
    {
        _square.ToggleVision();
    }

    #endregion

    #region --- Fields ---

    private SquareObject _square;

    #endregion
}
