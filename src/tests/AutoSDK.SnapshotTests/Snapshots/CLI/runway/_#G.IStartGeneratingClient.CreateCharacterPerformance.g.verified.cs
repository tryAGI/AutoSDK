//HintName: G.IStartGeneratingClient.CreateCharacterPerformance.g.cs
#nullable enable

namespace G
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Control a character<br/>
        /// This endpoint will start a new task to control a character's facial expressions and body movements using a reference video.
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
        /// const task = await client.characterPerformance<br/>
        ///   .create({<br/>
        ///     model: 'act_two',<br/>
        ///     character: {<br/>
        ///       type: 'video',<br/>
        ///       uri: 'https://example.com/posedCharacter.mp4',<br/>
        ///     },<br/>
        ///     reference: {<br/>
        ///       type: 'video',<br/>
        ///       uri: 'https://example.com/actorPerformance.mp4',<br/>
        ///     },<br/>
        ///     ratio: '1280:720',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateCharacterPerformanceResponse> CreateCharacterPerformanceAsync(

            global::G.CreateCharacterPerformanceRequest request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Control a character<br/>
        /// This endpoint will start a new task to control a character's facial expressions and body movements using a reference video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCharacterPerformanceResponse> CreateCharacterPerformanceAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}