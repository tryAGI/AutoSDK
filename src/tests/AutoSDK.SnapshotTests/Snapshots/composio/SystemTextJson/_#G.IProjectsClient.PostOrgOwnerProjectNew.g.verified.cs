//HintName: G.IProjectsClient.PostOrgOwnerProjectNew.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project<br/>
        /// Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostOrgOwnerProjectNewResponse> PostOrgOwnerProjectNewAsync(

            global::G.PostOrgOwnerProjectNewRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project<br/>
        /// Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.
        /// </summary>
        /// <param name="name">
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </param>
        /// <param name="shouldCreateApiKey">
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="config">
        /// Configuration for the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostOrgOwnerProjectNewResponse> PostOrgOwnerProjectNewAsync(
            string name,
            bool? shouldCreateApiKey = default,
            global::G.PostOrgOwnerProjectNewRequestConfig? config = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}