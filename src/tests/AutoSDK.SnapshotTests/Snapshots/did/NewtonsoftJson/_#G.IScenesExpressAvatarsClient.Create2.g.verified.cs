//HintName: G.IScenesExpressAvatarsClient.Create2.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Create a Scene
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Create2Response> Create2Async(

            global::G.Create2Request request,
            string? xApiKeyExternal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Scene
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="avatarId">
        /// The avatar that will be used to create the scene.
        /// </param>
        /// <param name="script"></param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including scene details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the scene
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the scene, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="background">
        /// Background color of the scene result, can only be used for avatars with green screen background
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Create2Response> Create2Async(
            string avatarId,
            global::G.AnyOf<global::G.Create2RequestScriptText, global::G.Create2RequestScriptAudio> script,
            string? xApiKeyExternal = default,
            string? webhook = default,
            string? userData = default,
            string? name = default,
            string? resultUrl = default,
            global::G.Create2RequestConfig? config = default,
            global::G.Create2RequestBackground? background = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}