namespace BlazorUtils.RenderModeDetector;

public interface IRenderModeDetector
{
    bool IsInteractive { get; }

    bool IsWebAssembly { get; }

    bool IsServer { get; }
}
