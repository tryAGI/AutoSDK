//HintName: G.IAudioIsolationClient.CreateAudioIsolationStream.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioIsolationClient
    {
        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAudioIsolationStreamAsync(
            global::G.BodyAudioIsolationStreamV1AudioIsolationStreamPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="audio">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="audioname">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAudioIsolationStreamAsync(
            byte[] audio,
            string audioname,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}