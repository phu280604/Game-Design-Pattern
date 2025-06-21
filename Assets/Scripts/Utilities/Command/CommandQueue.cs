using DesignParttern.Interfaces.Command;
using System.Collections.Generic;
using UnityEngine;

namespace DesignParttern.Utilities.Command
{
    /// <summary>
    /// CommandQueue - Lớp quản lý hàng đợi lệnh trong hệ thống.
    /// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
    /// </summary>
    public class CommandQueue
    {
        #region --- Methods ---

        /// <summary>
        /// Constructor - Khởi tạo một hàng đợi lệnh rỗng.
        /// </summary>
        public CommandQueue()
        {
            _commandList = new Stack<ICommand>();
        }

        /// <summary>
        /// Thêm một lệnh vào hàng đợi.
        /// </summary>
        public void AddCommand(ICommand newCommand)
        {
            newCommand.Execute();
            _commandList.Push(newCommand);
        }

        /// <summary>
        /// Hoàn tác lệnh cuối cùng trong hàng đợi.
        /// </summary>
        public void UndoCommand()
        {
            if (_commandList.Count > 0)
            {
                ICommand lastCommand = _commandList.Pop();
                lastCommand.Undo();
            }
        }

        #endregion

        #region --- Fields ---

        private readonly Stack<ICommand> _commandList;

        #endregion
    }
}
