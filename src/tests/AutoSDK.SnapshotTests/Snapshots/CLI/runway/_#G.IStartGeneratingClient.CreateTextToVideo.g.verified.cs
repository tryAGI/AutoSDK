//HintName: G.IStartGeneratingClient.CreateTextToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {

        /// <summary>
        /// Text to video<br/>
        /// This endpoint will start a new task to generate a video from a text prompt.
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
        /// const task = await client.textToVideo<br/>
        ///   .create({<br/>
        ///     model: 'veo3.1',<br/>
        ///     promptText: 'A cute bunny hopping in a meadow',<br/>
        ///     ratio: '1280:720',<br/>
        ///     duration: 8,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response5> CreateTextToVideoAsync(

            global::G.Request2 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Text to video<br/>
        /// This endpoint will start a new task to generate a video from a text prompt.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response5> CreateTextToVideoAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}