//HintName: G.ITemplatesClient.GetTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List all templates
        /// </summary>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Template>> GetTemplatesAsync(
            string? teamID = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}