// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EventGrid Partner Topic.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerTopic : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the PartnerTopic class.
        /// </summary>
        public PartnerTopic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerTopic class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="source">Source associated with this partner topic.
        /// This represents a unique partner resource.</param>
        /// <param name="provisioningState">Provisioning state of the partner
        /// topic. Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="activationState">Activation state of the partner
        /// topic. Possible values include: 'NeverActivated', 'Activated',
        /// 'Deactivated'</param>
        public PartnerTopic(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string source = default(string), string provisioningState = default(string), string activationState = default(string))
            : base(location, id, name, type, tags)
        {
            Source = source;
            ProvisioningState = provisioningState;
            ActivationState = activationState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source associated with this partner topic. This
        /// represents a unique partner resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets provisioning state of the partner topic. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets activation state of the partner topic. Possible values
        /// include: 'NeverActivated', 'Activated', 'Deactivated'
        /// </summary>
        [JsonProperty(PropertyName = "properties.activationState")]
        public string ActivationState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
