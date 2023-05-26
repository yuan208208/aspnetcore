// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Components.Web;

/// <summary>
/// A <see cref="IComponentRenderMode"/> indicating that the component should be rendered interactively on the server using Blazor Server hosting.
/// </summary>
public class ServerRenderMode : IComponentRenderMode
{
    /// <summary>
    /// Constructs an instance of <see cref="ServerRenderMode"/>.
    /// </summary>
    public ServerRenderMode() : this(true)
    {
    }

    /// <summary>
    /// Constructs an instance of <see cref="ServerRenderMode"/>
    /// </summary>
    /// <param name="prerender">A flag indicating whether the component should first prerender on the server. The default value is true.</param>
    public ServerRenderMode(bool prerender)
    {
        Prerender = prerender;
    }

    /// <summary>
    /// A flag indicating whether the component should first prerender on the server. The default value is true.
    /// </summary>
    public bool Prerender { get; }
}
