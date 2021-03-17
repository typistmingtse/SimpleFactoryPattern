using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    /// <summary>
    /// 抽象飲料界面
    /// </summary>
    public interface IBeverage
    {
        /// <summary>
        /// 付款
        /// </summary>
        void Pay();

        /// <summary>
        /// 拿吸管
        /// </summary>
        void Straw();
    }
}
