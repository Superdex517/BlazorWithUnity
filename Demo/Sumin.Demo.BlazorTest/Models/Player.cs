using Microsoft.AspNetCore.Components;
using Sumin.Demo.BlazorTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sumin.Demo.BlazorTest.Models
{
    public class Player : ComponentBase
    {
        [Inject] public ChatService service { get; set; }

        //초기화함수
        protected override async Task OnInitializedAsync()
        {
            this.service.addPlayer(this);

            await Task.CompletedTask;
        }

        public void render()
        {
            this.InvokeAsync(() =>
            {
                this.StateHasChanged();
            });
        }
    }
}
