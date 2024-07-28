using BlazorUtils.RenderModeDetector.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorUtils.RenderModeDetector.WebAssembly;

public static class RenderModeDetectorSetup
{
    public static IServiceCollection AddWebAssemblyRenderModeDetector(this IServiceCollection services)
    {
        services.AddTransient<IRenderModeDetector, RenderModeDetector>();
        return services;
    }
}
