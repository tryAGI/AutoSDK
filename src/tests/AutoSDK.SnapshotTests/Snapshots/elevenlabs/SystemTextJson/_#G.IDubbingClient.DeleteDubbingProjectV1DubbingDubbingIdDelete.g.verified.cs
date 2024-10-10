//HintName: G.IDubbingClient.DeleteDubbingProjectV1DubbingDubbingIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Delete Dubbing Project<br/>
        /// Deletes a dubbing project.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteDubbingProjectV1DubbingDubbingIdDeleteResponse> DeleteDubbingProjectV1DubbingDubbingIdDeleteAsync(
            string dubbingId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}