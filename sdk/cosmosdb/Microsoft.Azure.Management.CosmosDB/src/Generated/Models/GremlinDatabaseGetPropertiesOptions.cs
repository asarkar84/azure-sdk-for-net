// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class GremlinDatabaseGetPropertiesOptions : OptionsResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GremlinDatabaseGetPropertiesOptions class.
        /// </summary>
        public GremlinDatabaseGetPropertiesOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GremlinDatabaseGetPropertiesOptions class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput. Use the ThroughputSetting resource when retrieving
        /// offer details.</param>
        public GremlinDatabaseGetPropertiesOptions(int? throughput = default(int?))
            : base(throughput)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
