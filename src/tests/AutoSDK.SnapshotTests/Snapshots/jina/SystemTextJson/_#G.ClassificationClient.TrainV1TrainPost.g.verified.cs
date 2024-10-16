//HintName: G.ClassificationClient.TrainV1TrainPost.g.cs

#nullable enable

namespace G
{
    public partial class ClassificationClient
    {
        partial void PrepareTrainV1TrainPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.TrainingAPIInput request);
        partial void PrepareTrainV1TrainPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.TrainingAPIInput request);
        partial void ProcessTrainV1TrainPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainV1TrainPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingOutput> TrainV1TrainPostAsync(
            global::G.TrainingAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTrainV1TrainPostArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/train",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainV1TrainPostRequest(
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
            ProcessTrainV1TrainPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainV1TrainPostResponseContent(
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
                global::G.TrainingOutput.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="classifierId">
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="visibility">
        /// The visibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
        /// Default Value: public
        /// </param>
        /// <param name="input">
        /// List of text and images and labels or a single text and image and label to train the classifier
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingOutput> TrainV1TrainPostAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> input,
            string? model = default,
            string? classifierId = default,
            global::G.TrainingAPIInputVisibility? visibility = global::G.TrainingAPIInputVisibility.Public,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TrainingAPIInput
            {
                Model = model,
                ClassifierId = classifierId,
                Visibility = visibility,
                Input = input,
            };

            return await TrainV1TrainPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}