﻿//===============================================================================
// Microsoft patterns & practices
// Unity Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration.ConfigurationHelpers;

namespace Microsoft.Practices.Unity.Configuration
{
    /// <summary>
    /// A collection of <see cref="ContainerExtensionElement"/>s.
    /// </summary>
    [ConfigurationCollection(typeof(ContainerExtensionElement))]
    public class ContainerExtensionElementCollection : DeserializableConfigurationElementCollection<ContainerExtensionElement>
    {
        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Object"/> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to return the key for. 
        ///                 </param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ContainerExtensionElement) element).TypeName;
        }
    }
}
