//HintName: G.IToolsApiClient.CreateToolsTextToGraph.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Text-to-graph<br/>
        /// Performs name entity recognition on the supplied text accepting a maximum of 35000 words.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/text-to-graph \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"text":"A racecar has very powerful brakes that can decelerate from 200 km/h to 0 km/h in a few seconds"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.TextToGraphResponse> CreateToolsTextToGraphAsync(

            global::G.TextToGraphRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text-to-graph<br/>
        /// Performs name entity recognition on the supplied text accepting a maximum of 35000 words.
        /// </summary>
        /// <param name="text">
        /// The text to convert into a graph structure. Maximum of 35,000 words.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToGraphResponse> CreateToolsTextToGraphAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}