//HintName: G.IStartGeneratingClient.CreateTextToSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Text to speech<br/>
        /// This endpoint will start a new task to generate speech from text.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.textToSpeech<br/>
        ///   .create({<br/>
        ///     model: 'eleven_multilingual_v2',<br/>
        ///     promptText: 'The quick brown fox jumps over the lazy dog',<br/>
        ///     voice: {<br/>
        ///       type: 'runway-preset',<br/>
        ///       presetId: 'Leslie',<br/>
        ///     },<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateTextToSpeechResponse> CreateTextToSpeechAsync(

            global::G.CreateTextToSpeechRequest request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to speech<br/>
        /// This endpoint will start a new task to generate speech from text.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTextToSpeechResponse> CreateTextToSpeechAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}