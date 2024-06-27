//HintName: G.Api.DeleteModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Delete a model<br/>
        /// Delete a model<br/>
        /// Model deletion has some restrictions:<br/>
        /// - You can only delete models you own.<br/>
        /// - You can only delete private models.<br/>
        /// - You can only delete models that have versions associated with them (currently these will need to be deleted seperately).<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world<br/>
        /// ```<br/>
        /// The response will be an empty 204, indicating the model has been deleted.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeleteModelsAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/models/{modelOwner}/{modelName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}