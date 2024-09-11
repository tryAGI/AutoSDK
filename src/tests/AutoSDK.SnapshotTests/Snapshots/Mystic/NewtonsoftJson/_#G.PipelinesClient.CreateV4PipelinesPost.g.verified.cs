//HintName: G.PipelinesClient.CreateV4PipelinesPost.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareCreateV4PipelinesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PipelineCreate request);
        partial void PrepareCreateV4PipelinesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PipelineCreate request);
        partial void ProcessCreateV4PipelinesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateV4PipelinesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create<br/>
        /// Upload a new pipeline.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PipelineGet> CreateV4PipelinesPostAsync(
            global::G.PipelineCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateV4PipelinesPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v4/pipelines", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateV4PipelinesPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateV4PipelinesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateV4PipelinesPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PipelineGet?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create<br/>
        /// Upload a new pipeline.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="cluster"></param>
        /// <param name="scalingConfig"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="extras"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PipelineGet> CreateV4PipelinesPostAsync(
            string name,
            string image,
            global::System.Collections.Generic.IList<global::G.IOVariable> inputVariables,
            global::System.Collections.Generic.IList<global::G.IOVariable> outputVariables,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators = default,
            global::G.PipelineClusterConfig? cluster = default,
            string? scalingConfig = default,
            string? description = default,
            string? readme = default,
            global::G.PipelineCreateExtras? extras = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PipelineCreate
            {
                Name = name,
                Image = image,
                InputVariables = inputVariables,
                OutputVariables = outputVariables,
                Accelerators = accelerators,
                Cluster = cluster,
                ScalingConfig = scalingConfig,
                Description = description,
                Readme = readme,
                Extras = extras,
            };

            return await CreateV4PipelinesPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}