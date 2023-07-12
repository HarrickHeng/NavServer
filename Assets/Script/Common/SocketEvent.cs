using System;
using System.Collections.Generic;

namespace HHFramework
{
    /// <summary>
    /// Socket事件
    /// </summary>
    public class SocketEvent : IDisposable
    {
        public delegate void OnActionHandler(byte[] buffer);

        private readonly Dictionary<ushort, LinkedList<OnActionHandler>> mDic;

        public SocketEvent()
        {
            mDic = new Dictionary<ushort, LinkedList<OnActionHandler>>();
        }

        #region AddEventListener 添加监听

        /// <summary>
        /// 添加监听
        /// </summary>
        /// <param name="key"></param>
        /// <param name="handler"></param>
        public void AddEventListener(ushort key, OnActionHandler handler)
        {
            mDic.TryGetValue(key, out var lstHandler);

            if (lstHandler == null)
            {
                lstHandler = new LinkedList<OnActionHandler>();
                mDic[key] = lstHandler;
            }

            lstHandler.AddLast(handler);
        }

        #endregion

        #region RemoveEventListener 移除监听

        /// <summary>
        /// 移除监听
        /// </summary>
        /// <param name="key"></param>
        /// <param name="handler"></param>
        public void RemoveEventListener(ushort key, OnActionHandler handler)
        {
            mDic.TryGetValue(key, out var lstHandler);

            if (lstHandler == null) return;

            mDic[key].Remove(handler);
            if (mDic[key].Count == 0)
            {
                mDic.Remove(key);
            }
        }

        #endregion

        #region Dispatch 派发

        /// <summary>
        /// 派发
        /// </summary>
        /// <param name="key"></param>
        /// <param name="buffer"></param>
        public void Dispatch(ushort key, byte[] buffer)
        {
            mDic.TryGetValue(key, out var lstHandler);

            if (lstHandler == null) return;

            for (var curr = lstHandler.First; curr != null; curr = curr.Next)
            {
                var handler = curr.Value;
                if (handler != null)
                {
                    handler(buffer);
                }
            }
        }

        public void Dispatch(ushort key)
        {
            Dispatch(key, null);
        }

        #endregion

        public void Dispose()
        {
            mDic.Clear();
        }
    }
}