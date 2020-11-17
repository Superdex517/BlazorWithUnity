using Sumin.Demo.BlazorTest.Models;
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

        public List<Player> players { get; set; } = new List<Player>();

        public void addMessage(string message)
        {
            this.messages.Add(message);

            foreach(var player in this.players)
            {
                player.render();
            }
        }

        internal void addPlayer(Player player)
        {
            this.players.Add(player);
        }
    }
}
