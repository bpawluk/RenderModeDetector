# How to use
## Blazor Server project
### Install **BlazorUtils.RenderModeDetector.Server** NuGet package
```
<PackageReference Include="BlazorUtils.RenderModeDetector.Server" Version="2.0.0" />
```
### Register the detector
```
using BlazorUtils.RenderModeDetector.Server;

builder.Services.AddServerRenderModeDetector();
```

## Blazor WebAssembly project
### Install **BlazorUtils.RenderModeDetector.WebAssembly** NuGet package
```
<PackageReference Include="BlazorUtils.RenderModeDetector.WebAssembly" Version="2.0.0" />
```
### Register the detector
```
using BlazorUtils.RenderModeDetector.WebAssembly;

builder.Services.AddWebAssemblyRenderModeDetector();
```
## Usage
```
@using BlazorUtils.RenderModeDetector

@inject IRenderModeDetector RenderModeDetector

<p>IsInteractive: @RenderModeDetector.IsInteractive</p>
<p>IsWebAssembly: @RenderModeDetector.IsWebAssembly</p>
<p>IsServer: @RenderModeDetector.IsServer</p>
```
