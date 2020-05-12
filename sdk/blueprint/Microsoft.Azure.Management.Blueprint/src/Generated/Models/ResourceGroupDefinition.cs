// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an Azure resource group in a blueprint definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResourceGroupDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupDefinition class.
        /// </summary>
        public ResourceGroupDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupDefinition class.
        /// </summary>
        /// <param name="name">Name of this resourceGroup. Leave empty if the
        /// resource group name will be specified during the blueprint
        /// assignment.</param>
        /// <param name="location">Location of this resourceGroup. Leave empty
        /// if the resource group location will be specified during the
        /// blueprint assignment.</param>
        /// <param name="displayName">DisplayName of this
        /// parameter/resourceGroup.</param>
        /// <param name="description">Description of this
        /// parameter/resourceGroup.</param>
        /// <param name="strongType">StrongType for UI to render rich
        /// experience during blueprint assignment. Supported strong types are
        /// resourceType, principalId and location.</param>
        /// <param name="dependsOn">Artifacts which need to be deployed before
        /// this resource group.</param>
        /// <param name="tags">Tags to be assigned to this resource
        /// group.</param>
        public ResourceGroupDefinition(string name = default(string), string location = default(string), string displayName = default(string), string description = default(string), string strongType = default(string), IList<string> dependsOn = default(IList<string>), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Name = name;
            Location = location;
            DisplayName = displayName;
            Description = description;
            StrongType = strongType;
            DependsOn = dependsOn;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of this resourceGroup. Leave empty if the
        /// resource group name will be specified during the blueprint
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets location of this resourceGroup. Leave empty if the
        /// resource group location will be specified during the blueprint
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets displayName of this parameter/resourceGroup.
        /// </summary>
        [JsonProperty(PropertyName = "metadata.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of this parameter/resourceGroup.
        /// </summary>
        [JsonProperty(PropertyName = "metadata.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets strongType for UI to render rich experience during
        /// blueprint assignment. Supported strong types are resourceType,
        /// principalId and location.
        /// </summary>
        [JsonProperty(PropertyName = "metadata.strongType")]
        public string StrongType { get; set; }

        /// <summary>
        /// Gets or sets artifacts which need to be deployed before this
        /// resource group.
        /// </summary>
        [JsonProperty(PropertyName = "dependsOn")]
        public IList<string> DependsOn { get; set; }

        /// <summary>
        /// Gets or sets tags to be assigned to this resource group.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
            }
            if (StrongType != null)
            {
                if (StrongType.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "StrongType", 64);
                }
            }
        }
    }
}
