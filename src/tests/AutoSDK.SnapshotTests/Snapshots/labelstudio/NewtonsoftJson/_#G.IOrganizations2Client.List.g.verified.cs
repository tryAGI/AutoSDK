//HintName: G.IOrganizations2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizations2Client
    {
        /// <summary>
        /// List your organizations<br/>
        ///         Return a list of the organizations you've created or that you have access to.<br/>
        ///         
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationId>> ListAsync(
            string? ordering = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}