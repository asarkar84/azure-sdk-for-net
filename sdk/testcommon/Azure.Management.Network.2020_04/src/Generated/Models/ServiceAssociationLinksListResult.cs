// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ServiceAssociationLinks_List operation. </summary>
    public partial class ServiceAssociationLinksListResult
    {
        /// <summary> Initializes a new instance of ServiceAssociationLinksListResult. </summary>
        internal ServiceAssociationLinksListResult()
        {
        }

        /// <summary> Initializes a new instance of ServiceAssociationLinksListResult. </summary>
        /// <param name="value"> The service association links in a subnet. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ServiceAssociationLinksListResult(IReadOnlyList<ServiceAssociationLink> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The service association links in a subnet. </summary>
        public IReadOnlyList<ServiceAssociationLink> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
