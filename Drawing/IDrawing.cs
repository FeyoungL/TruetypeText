using System;
using System.Collections.Generic;
using System.Text;

namespace TrueTypeText.Drawing
{
    /// <summary>
    /// ��ͼ�ӿ�
    /// </summary>
    public interface IDrawing
    {
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="context">��ͼ������</param>
        void Draw(IDrawingContext context);
    }
}
