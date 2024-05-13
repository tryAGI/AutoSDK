//HintName: G.Api.EndPoints.ModifyThread.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Modifies a thread.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ThreadObject> ModifyThreadAsync(
            ModifyThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/threads/{thread_id}");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ThreadObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Modifies a thread.
        /// </summary>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ThreadObject> ModifyThreadAsync(
            ModifyThreadRequestToolResources? toolResources,
            ModifyThreadRequestMetadata? metadata,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ModifyThreadRequest
            {
                ToolResources = toolResources,
                Metadata = metadata,
            };

            return await ModifyThreadAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}