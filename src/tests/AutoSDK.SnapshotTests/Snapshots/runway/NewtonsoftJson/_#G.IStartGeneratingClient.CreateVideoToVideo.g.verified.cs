//HintName: G.IStartGeneratingClient.CreateVideoToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Video to video<br/>
        /// This endpoint will start a new task to generate a video from a video.
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
        /// const task = await client.videoToVideo<br/>
        ///   .create({<br/>
        ///     model: 'gen4_aleph',<br/>
        ///     videoUri: 'https://example.com/bunny.mp4',<br/>
        ///     promptText: 'string',<br/>
        ///     references: [<br/>
        ///       {<br/>
        ///         type: 'image',<br/>
        ///         uri: 'https://example.com/easter-scene.jpg',<br/>
        ///       },<br/>
        ///     ],<br/>
        ///     ratio: '1280:720',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response7> CreateVideoToVideoAsync(

            global::G.Request3 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video to video<br/>
        /// This endpoint will start a new task to generate a video from a video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response7> CreateVideoToVideoAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}