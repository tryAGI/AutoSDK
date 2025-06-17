﻿//HintName: G.IConnectorsClient.UpdateConnector.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Update a Connector<br/>
        /// Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConnectorResponse> UpdateConnectorAsync(
            string id,
            global::G.UpdateConnectorRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a Connector<br/>
        /// Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Default Value: false
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="serviceAuth"></param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConnectorResponse> UpdateConnectorAsync(
            string id,
            string? xClientName = default,
            bool? active = default,
            bool? continueOnFailure = default,
            global::System.Collections.Generic.IList<string>? excludes = default,
            string? name = default,
            global::G.CreateConnectorOAuth? oauth = default,
            global::G.CreateConnectorServiceAuth? serviceAuth = default,
            string? url = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}