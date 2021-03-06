// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> ExpressRouteConnection resource. </summary>
    public partial class ExpressRouteConnection : SubResource
    {
        /// <summary> Initializes a new instance of ExpressRouteConnection. </summary>
        /// <param name="name"> The name of the resource. </param>
        public ExpressRouteConnection(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of ExpressRouteConnection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the express route connection resource. </param>
        /// <param name="expressRouteCircuitPeering"> The ExpressRoute circuit peering. </param>
        /// <param name="authorizationKey"> Authorization key to establish the connection. </param>
        /// <param name="routingWeight"> The routing weight associated to the connection. </param>
        /// <param name="enableInternetSecurity"> Enable internet security. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        internal ExpressRouteConnection(string id, string name, ProvisioningState? provisioningState, ExpressRouteCircuitPeeringId expressRouteCircuitPeering, string authorizationKey, int? routingWeight, bool? enableInternetSecurity, RoutingConfiguration routingConfiguration) : base(id)
        {
            Name = name;
            ProvisioningState = provisioningState;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            AuthorizationKey = authorizationKey;
            RoutingWeight = routingWeight;
            EnableInternetSecurity = enableInternetSecurity;
            RoutingConfiguration = routingConfiguration;
        }

        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The provisioning state of the express route connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The ExpressRoute circuit peering. </summary>
        public ExpressRouteCircuitPeeringId ExpressRouteCircuitPeering { get; set; }
        /// <summary> Authorization key to establish the connection. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The routing weight associated to the connection. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> Enable internet security. </summary>
        public bool? EnableInternetSecurity { get; set; }
        /// <summary> The Routing Configuration indicating the associated and propagated route tables on this connection. </summary>
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}
