//HintName: G.IStartGeneratingClient.CreateImageToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Image to video<br/>
        /// This endpoint will start a new task to generate a video from an image.
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
        /// const task = await client.imageToVideo<br/>
        ///   .create({<br/>
        ///     model: 'gen4_turbo',<br/>
        ///     promptImage: 'https://example.com/bunny.jpg',<br/>
        ///     promptText: 'A cute bunny hopping in a meadow',<br/>
        ///     duration: 10,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateImageToVideoResponse> CreateImageToVideoAsync(

            global::G.CreateImageToVideoRequest request,
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to video<br/>
        /// This endpoint will start a new task to generate a video from an image.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateImageToVideoResponse> CreateImageToVideoAsync(
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}