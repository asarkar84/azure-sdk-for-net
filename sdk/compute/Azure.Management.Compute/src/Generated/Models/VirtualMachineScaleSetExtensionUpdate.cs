// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a Virtual Machine Scale Set Extension. </summary>
    public partial class VirtualMachineScaleSetExtensionUpdate : SubResourceReadOnly
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetExtensionUpdate. </summary>
        public VirtualMachineScaleSetExtensionUpdate()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetExtensionUpdate. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The name of the extension. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="forceUpdateTag"> If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="typePropertiesType"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="provisionAfterExtensions"> Collection of extension names after which this extension needs to be provisioned. </param>
        internal VirtualMachineScaleSetExtensionUpdate(string id, string name, string type, string forceUpdateTag, string publisher, string typePropertiesType, string typeHandlerVersion, bool? autoUpgradeMinorVersion, object settings, object protectedSettings, string provisioningState, IList<string> provisionAfterExtensions) : base(id)
        {
            Name = name;
            Type = type;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            TypePropertiesType = typePropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            ProvisionAfterExtensions = provisionAfterExtensions;
        }

        /// <summary> The name of the extension. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string TypePropertiesType { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary> Json formatted public settings for the extension. </summary>
        public object Settings { get; set; }
        /// <summary> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </summary>
        public object ProtectedSettings { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Collection of extension names after which this extension needs to be provisioned. </summary>
        public IList<string> ProvisionAfterExtensions { get; set; }
    }
}
