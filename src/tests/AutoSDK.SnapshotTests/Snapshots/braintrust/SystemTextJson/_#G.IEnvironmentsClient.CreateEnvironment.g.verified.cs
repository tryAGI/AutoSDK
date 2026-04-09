//HintName: G.IEnvironmentsClient.CreateEnvironment.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Create environment<br/>
        /// Create a new environment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Environment> CreateEnvironmentAsync(

            global::G.CreateEnvironment request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create environment<br/>
        /// Create a new environment
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="slug">
        /// A url-friendly, unique identifier for the environment within an organization
        /// </param>
        /// <param name="description">
        /// Textual description of the environment
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the environment belongs in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Environment> CreateEnvironmentAsync(
            string name,
            string slug,
            string? description = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}