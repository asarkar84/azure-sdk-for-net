// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.KeyVault.Models;

namespace Azure.Management.KeyVault
{
    /// <summary> The PrivateEndpointConnections service client. </summary>
    public partial class PrivateEndpointConnectionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateEndpointConnectionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PrivateEndpointConnectionsClient for mocking. </summary>
        protected PrivateEndpointConnectionsClient()
        {
        }
        /// <summary> Initializes a new instance of PrivateEndpointConnectionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PrivateEndpointConnectionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-09-01")
        {
            RestClient = new PrivateEndpointConnectionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnection>> GetAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vaultName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnection> Get(string resourceGroupName, string vaultName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vaultName, privateEndpointConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnection>> PutAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.Put");
            scope.Start();
            try
            {
                return await RestClient.PutAsync(resourceGroupName, vaultName, privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnection> Put(string resourceGroupName, string vaultName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.Put");
            scope.Start();
            try
            {
                return RestClient.Put(resourceGroupName, vaultName, privateEndpointConnectionName, properties, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PrivateEndpointConnectionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, vaultName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                return new PrivateEndpointConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vaultName, privateEndpointConnectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified private endpoint connection associated with the key vault. </summary>
        /// <param name="resourceGroupName"> Name of the resource group that contains the key vault. </param>
        /// <param name="vaultName"> The name of the key vault. </param>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the key vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PrivateEndpointConnectionsDeleteOperation StartDelete(string resourceGroupName, string vaultName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, vaultName, privateEndpointConnectionName, cancellationToken);
                return new PrivateEndpointConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vaultName, privateEndpointConnectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
