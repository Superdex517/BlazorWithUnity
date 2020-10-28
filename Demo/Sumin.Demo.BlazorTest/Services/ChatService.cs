using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sumin.Demo.BlazorTest.Services
{
    public class ChatService
    {
        /// 전체 채팅 메시지 목록 ///
        public List<string> messages { get; private set; } = new List<string>();

        public void addMessage(string message)
        {
            this.messages.Add(message);
        }
    }
}
