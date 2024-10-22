﻿
using BlazingPizzaria.Models.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;

namespace BlazingPizza.Dependencias
{
    /// <summary>
    ///  Todas dependências de serviços do projeto 
    /// </summary>
    public partial class InjectServicesWeb
    {
        public readonly ILogger<ProdutoDtos> _logger;

        public HttpClient _httpClient { get; set; }

        public readonly IJSRuntime _jSRuntime;

        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Inject]
        public DialogService _dialogService { get; set; }

        [Inject]
        public TooltipService _tooltipService { get; set; }

        [Inject]
        public ContextMenuService _contextMenuService { get; set; }

        [Inject]
        public NotificationService _notificationService { get; set; }


        public InjectServicesWeb(ILogger<ProdutoDtos> Logger, HttpClient HttpClient, IJSRuntime JSRuntime,
            NavigationManager NavigationManager)
        {
            _logger = Logger;
            _httpClient = HttpClient;
            _navigationManager = NavigationManager;

        }
    }
}
