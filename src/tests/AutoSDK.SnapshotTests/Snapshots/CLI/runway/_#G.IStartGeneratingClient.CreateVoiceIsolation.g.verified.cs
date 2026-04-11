//HintName: G.IStartGeneratingClient.CreateVoiceIsolation.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Voice isolation<br/>
        /// This endpoint will start a new task to isolate the voice from the background audio. Audio duration must be greater than 4.6 seconds and less than 3600 seconds.
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
        /// const task = await client.voiceIsolation<br/>
        ///   .create({<br/>
        ///     model: 'eleven_voice_isolation',<br/>
        ///     audioUrl: 'https://example.com/audio.mp3',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateVoiceIsolationResponse> CreateVoiceIsolationAsync(

            global::G.CreateVoiceIsolationRequest request,
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice isolation<br/>
        /// This endpoint will start a new task to isolate the voice from the background audio. Audio duration must be greater than 4.6 seconds and less than 3600 seconds.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVoiceIsolationResponse> CreateVoiceIsolationAsync(
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}