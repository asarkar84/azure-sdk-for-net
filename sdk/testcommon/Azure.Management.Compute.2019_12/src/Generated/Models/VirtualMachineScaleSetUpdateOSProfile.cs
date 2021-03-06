// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a virtual machine scale set OS profile. </summary>
    public partial class VirtualMachineScaleSetUpdateOSProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateOSProfile. </summary>
        public VirtualMachineScaleSetUpdateOSProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateOSProfile. </summary>
        /// <param name="customData"> A base-64 encoded string of custom data. </param>
        /// <param name="windowsConfiguration"> The Windows Configuration of the OS profile. </param>
        /// <param name="linuxConfiguration"> The Linux Configuration of the OS profile. </param>
        /// <param name="secrets"> The List of certificates for addition to the VM. </param>
        internal VirtualMachineScaleSetUpdateOSProfile(string customData, WindowsConfiguration windowsConfiguration, LinuxConfiguration linuxConfiguration, IList<VaultSecretGroup> secrets)
        {
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
        }

        /// <summary> A base-64 encoded string of custom data. </summary>
        public string CustomData { get; set; }
        /// <summary> The Windows Configuration of the OS profile. </summary>
        public WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary> The Linux Configuration of the OS profile. </summary>
        public LinuxConfiguration LinuxConfiguration { get; set; }
        /// <summary> The List of certificates for addition to the VM. </summary>
        public IList<VaultSecretGroup> Secrets { get; set; }
    }
}
