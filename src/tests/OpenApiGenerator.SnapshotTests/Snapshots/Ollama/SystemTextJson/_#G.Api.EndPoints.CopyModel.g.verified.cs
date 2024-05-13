//HintName: G.Api.EndPoints.CopyModel.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates a model with another name from an existing model.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CopyModelAsync(
            CopyModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/copy");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Creates a model with another name from an existing model.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CopyModelAsync(
            string source,
            string destination,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CopyModelRequest
    	    {
                Source = source,
                Destination = destination,
            };

            await CopyModelAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}