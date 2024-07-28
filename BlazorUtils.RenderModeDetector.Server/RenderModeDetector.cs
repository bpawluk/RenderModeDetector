using BlazorUtils.RenderModeDetector.Shared;
using Microsoft.AspNetCore.Http;

namespace BlazorUtils.RenderModeDetector.Server;

internal class RenderModeDetector(IHttpContextAccessor accessor) : IRenderModeDetector
{
    private readonly IHttpContextAccessor _accessor = accessor;

    public bool IsInteractive => _accessor.HttpContext?.WebSockets.IsWebSocketRequest != false;

    public bool IsWebAssembly => false;

    public bool IsServer => true;
}
