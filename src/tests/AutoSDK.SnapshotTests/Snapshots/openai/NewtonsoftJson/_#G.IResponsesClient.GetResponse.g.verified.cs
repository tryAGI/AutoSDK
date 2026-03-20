//HintName: G.IResponsesClient.GetResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Retrieves a model response with the given ID.
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="include"></param>
        /// <param name="stream"></param>
        /// <param name="startingAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> GetResponseAsync(
            string responseId,
            global::System.Collections.Generic.IList<global::G.Includable>? include = default,
            bool? stream = default,
            int? startingAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}