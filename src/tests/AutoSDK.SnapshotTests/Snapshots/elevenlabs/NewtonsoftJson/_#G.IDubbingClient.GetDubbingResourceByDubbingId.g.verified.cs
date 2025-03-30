//HintName: G.IDubbingClient.GetDubbingResourceByDubbingId.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get The Dubbing Resource For An Id.<br/>
        /// Given a dubbing ID generated from the '/v1/dubbing' endpoint with studio enabled, returns the dubbing resource.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DubbingResource> GetDubbingResourceByDubbingIdAsync(
            string dubbingId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}