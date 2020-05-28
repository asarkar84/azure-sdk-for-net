// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class PasswordCredentialListResult
    {
        internal static PasswordCredentialListResult DeserializePasswordCredentialListResult(JsonElement element)
        {
            IReadOnlyList<PasswordCredential> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PasswordCredential> array = new List<PasswordCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(PasswordCredential.DeserializePasswordCredential(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new PasswordCredentialListResult(value);
        }
    }
}
