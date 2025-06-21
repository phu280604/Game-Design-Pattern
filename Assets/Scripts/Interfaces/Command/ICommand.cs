using UnityEngine;

namespace DesignParttern.Interfaces.Command
{
    /// <summary>
    /// ICommand - Interface cho các lệnh trong hệ thống.
    /// Tác giả: Dương Nhật Khoa - Ngày tạo: 21/06/2025.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Thực hiện lệnh.
        /// </summary>
        void Execute();

        /// <summary>
        /// Hoàn tác lệnh.
        /// </summary>
        void Undo();
    }
}