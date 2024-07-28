using BlazorUtils.RenderModeDetector.Shared;

namespace BlazorUtils.RenderModeDetector.WebAssembly;

internal class RenderModeDetector : IRenderModeDetector
{
    public bool IsInteractive => true;

    public bool IsWebAssembly => true;

    public bool IsServer => false;
}
