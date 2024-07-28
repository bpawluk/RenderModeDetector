using Microsoft.Extensions.DependencyInjection;

namespace BlazorUtils.RenderModeDetector.Server;

public static class RenderModeDetectorSetup
{
    public static IServiceCollection AddServerRenderModeDetector(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddTransient<IRenderModeDetector, RenderModeDetector>();
        return services;
    }
}
