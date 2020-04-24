using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TrueTypeText.Drawing
{
    /// <summary>
    /// ��ͼ�����Ľӿ�
    /// </summary>
    public interface IDrawingContext
    {
        /// <summary>
        /// ��ȡ����
        /// </summary>
        Graphics Graphics { get;}
        /// <summary>
        /// ��ȡ����
        /// </summary>
        Pen Pen { get;}
        /// <summary>
        /// ��ȡ��ˢ
        /// </summary>
        Brush Brush { get;}
    }
}
