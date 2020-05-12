// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cognitive Services Account is an Azure resource representing the
    /// provisioned account, its type, location and SKU.
    /// </summary>
    public partial class CognitiveServicesAccount : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccount class.
        /// </summary>
        public CognitiveServicesAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccount class.
        /// </summary>
        /// <param name="etag">Entity Tag</param>
        /// <param name="id">The id of the created account</param>
        /// <param name="kind">The Kind of the resource.</param>
        /// <param name="location">The location of the resource</param>
        /// <param name="name">The name of the created account</param>
        /// <param name="properties">Properties of Cognitive Services
        /// account.</param>
        /// <param name="sku">The SKU of Cognitive Services account.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater than 128 characters and value no greater than 256
        /// characters.</param>
        /// <param name="type">Resource type</param>
        /// <param name="identity">The identity of Cognitive Services
        /// account.</param>
        public CognitiveServicesAccount(string etag = default(string), string id = default(string), string kind = default(string), string location = default(string), string name = default(string), CognitiveServicesAccountProperties properties = default(CognitiveServicesAccountProperties), Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), string type = default(string), Identity identity = default(Identity))
        {
            Etag = etag;
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            Properties = properties;
            Sku = sku;
            Tags = tags;
            Type = type;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets entity Tag
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the id of the created account
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the Kind of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets the name of the created account
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets properties of Cognitive Services account.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CognitiveServicesAccountProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the SKU of Cognitive Services account.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key no greater than 128 characters
        /// and value no greater than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the identity of Cognitive Services account.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
