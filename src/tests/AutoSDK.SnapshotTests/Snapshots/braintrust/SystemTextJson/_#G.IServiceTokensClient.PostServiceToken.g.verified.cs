//HintName: G.IServiceTokensClient.PostServiceToken.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceTokensClient
    {
        /// <summary>
        /// Create service_token<br/>
        /// Create a new service_token. It is possible to have multiple API keys with the same name. There is no de-duplication
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateServiceTokenOutput> PostServiceTokenAsync(

            global::G.PostServiceTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create service_token<br/>
        /// Create a new service_token. It is possible to have multiple API keys with the same name. There is no de-duplication
        /// </summary>
        /// <param name="name">
        /// Name of the service token. Does not have to be unique
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </param>
        /// <param name="serviceAccountId">
        /// The service account ID this service token should belong to. You can create a service account in the Braintrust [organization settings page](https://www.braintrustdata.com/app/settings?subroute=service-tokens) or using the [modify organization membership endpoint](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateServiceTokenOutput> PostServiceTokenAsync(
            string name,
            string serviceAccountId,
            string? orgName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}