//HintName: G.IProfileImagesClient.GetProfileImage.g.cs
#nullable enable

namespace G
{
    public partial interface IProfileImagesClient
    {
        /// <summary>
        /// A Users or organizations profile image<br/>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its<br/>
        ///         corresponding username.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProfileImageAsync(
            string username,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}