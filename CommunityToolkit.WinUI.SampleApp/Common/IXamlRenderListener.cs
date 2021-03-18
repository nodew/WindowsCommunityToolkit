// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.UI.Xaml;

namespace Microsoft.Toolkit.Uwp.SampleApp
{
    public interface IXamlRenderListener
    {
        void OnXamlRendered(FrameworkElement control);
    }
}