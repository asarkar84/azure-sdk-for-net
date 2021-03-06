// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class GatewayRoute
    {
        internal static GatewayRoute DeserializeGatewayRoute(JsonElement element)
        {
            string localAddress = default;
            string network = default;
            string nextHop = default;
            string sourcePeer = default;
            string origin = default;
            string asPath = default;
            int? weight = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("network"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    network = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHop"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextHop = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePeer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourcePeer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
            }
            return new GatewayRoute(localAddress, network, nextHop, sourcePeer, origin, asPath, weight);
        }
    }
}
