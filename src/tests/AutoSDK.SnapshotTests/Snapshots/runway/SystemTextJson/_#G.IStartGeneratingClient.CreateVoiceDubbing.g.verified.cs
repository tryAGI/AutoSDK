//HintName: G.IStartGeneratingClient.CreateVoiceDubbing.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Voice dubbing<br/>
        /// This endpoint will start a new task to dub audio content to a target language.
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
        /// const task = await client.voiceDubbing<br/>
        ///   .create({<br/>
        ///     model: 'eleven_voice_dubbing',<br/>
        ///     audioUri: 'https://example.com/audio.mp3',<br/>
        ///     targetLang: 'es',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response19> CreateVoiceDubbingAsync(

            global::G.Request9 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice dubbing<br/>
        /// This endpoint will start a new task to dub audio content to a target language.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response19> CreateVoiceDubbingAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}