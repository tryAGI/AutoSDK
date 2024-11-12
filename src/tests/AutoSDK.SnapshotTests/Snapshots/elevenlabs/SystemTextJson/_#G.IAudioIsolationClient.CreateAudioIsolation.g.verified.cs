//HintName: G.IAudioIsolationClient.CreateAudioIsolation.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioIsolationClient
    {
        /// <summary>
        /// Audio Isolation<br/>
        /// Removes background noise from audio
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAudioIsolationAsync(
            global::G.BodyAudioIsolationV1AudioIsolationPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Audio Isolation<br/>
        /// Removes background noise from audio
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
        global::System.Threading.Tasks.Task CreateAudioIsolationAsync(
            byte[] audio,
            string audioname,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}