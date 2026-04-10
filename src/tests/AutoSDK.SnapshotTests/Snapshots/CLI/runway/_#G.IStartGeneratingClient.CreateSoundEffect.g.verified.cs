//HintName: G.IStartGeneratingClient.CreateSoundEffect.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Generate sound effects<br/>
        /// This endpoint will start a new task to generate sound effects from a text description.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.soundEffect<br/>
        ///   .create({<br/>
        ///     model: 'eleven_text_to_sound_v2',<br/>
        ///     promptText: 'A thunderstorm with heavy rain',<br/>
        ///     duration: 10,<br/>
        ///     loop: true,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateSoundEffectResponse> CreateSoundEffectAsync(

            global::G.CreateSoundEffectRequest request,
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate sound effects<br/>
        /// This endpoint will start a new task to generate sound effects from a text description.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSoundEffectResponse> CreateSoundEffectAsync(
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}