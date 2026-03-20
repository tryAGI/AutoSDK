//HintName: G.IStartGeneratingClient.CreateSpeechToSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Speech to speech<br/>
        /// This endpoint will start a new task to convert speech from one voice to another in audio or video.
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
        /// const audioTask = await client.speechToSpeech<br/>
        ///   .create({<br/>
        ///     model: 'eleven_multilingual_sts_v2',<br/>
        ///     media: {<br/>
        ///       type: 'audio',<br/>
        ///       uri: 'https://example.com/audio.mp3',<br/>
        ///     },<br/>
        ///     voice: {<br/>
        ///       type: 'runway-preset',<br/>
        ///       presetId: 'Maggie',<br/>
        ///     },<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(audioTask);<br/>
        /// const videoTask = await client.speechToSpeech<br/>
        ///   .create({<br/>
        ///     model: 'eleven_multilingual_sts_v2',<br/>
        ///     media: {<br/>
        ///       type: 'video',<br/>
        ///       uri: 'https://example.com/video.mp4',<br/>
        ///     },<br/>
        ///     voice: {<br/>
        ///       type: 'runway-preset',<br/>
        ///       presetId: 'Noah',<br/>
        ///     },<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(videoTask);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response15> CreateSpeechToSpeechAsync(

            global::G.Request7 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech to speech<br/>
        /// This endpoint will start a new task to convert speech from one voice to another in audio or video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response15> CreateSpeechToSpeechAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}