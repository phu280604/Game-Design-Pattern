using DesignParttern.Interfaces.Command;
using DesignParttern.Utilities.Command;
using UnityEngine;

/// <summary>
/// UserInput - Lớp quản lý đầu vào của người dùng trong hệ thống Unity.
/// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
/// </summary>
public class UserInput : MonoBehaviour
{
    #region --- Unity Methods ---

    void Start()
    {
        _commandQueue = new CommandQueue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand toggleVisionCommand = new ToggleVisionCommand(_square);
            _commandQueue.AddCommand(toggleVisionCommand);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ICommand changeColorCommand = new ChangeColorCommand(_square);
            _commandQueue.AddCommand(changeColorCommand);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _commandQueue.UndoCommand();
        }
    }

    #endregion

    #region --- Fields ---

    private CommandQueue _commandQueue;

    [SerializeField] private SquareObject _square;

    #endregion

}
