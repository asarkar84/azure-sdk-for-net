// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identity properties of the Api Management service resource.
    /// </summary>
    public partial class ApiManagementServiceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ApiManagementServiceIdentity
        /// class.
        /// </summary>
        public ApiManagementServiceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementServiceIdentity
        /// class.
        /// </summary>
        /// <param name="type">The type of identity used for the resource. The
        /// type 'SystemAssigned, UserAssigned' includes both an implicitly
        /// created identity and a set of user assigned identities. The type
        /// 'None' will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'</param>
        /// <param name="principalId">The principal id of the identity.</param>
        /// <param name="tenantId">The client tenant id of the
        /// identity.</param>
        /// <param name="userAssignedIdentities">The list of user identities
        /// associated with the resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.</param>
        public ApiManagementServiceIdentity(string type, System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), IDictionary<string, UserIdentityProperties> userAssignedIdentities = default(IDictionary<string, UserIdentityProperties>))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of identity used for the resource. The type
        /// 'SystemAssigned, UserAssigned' includes both an implicitly created
        /// identity and a set of user assigned identities. The type 'None'
        /// will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the principal id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client tenant id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the list of user identities associated with the
        /// resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, UserIdentityProperties> UserAssignedIdentities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
