//HintName: G.Api.CreatePredictionsModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreatePredictionsModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelOwner,
            ref string modelName,
            global::G.PredictionRequest request);
        partial void PrepareCreatePredictionsModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelOwner,
            string modelName,
            global::G.PredictionRequest request);
        partial void ProcessCreatePredictionsModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePredictionsModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a prediction using an official model<br/>
        /// Start a new prediction for an official model using the inputs you provide.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "input": {<br/>
        ///     "prompt": "Write a short poem about the weather."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"input": {"prompt": "Write a short poem about the weather."}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/models/meta/meta-llama-3-70b-instruct/predictions<br/>
        /// ```<br/>
        /// The response will be the prediction object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "25s2s4n7rdrgg0cf1httb3myk0",<br/>
        ///   "model": "replicate-internal/llama3-70b-chat-vllm-unquantized",<br/>
        ///   "version": "dp-cf04fe09351e25db628e8b6181276547",<br/>
        ///   "input": {<br/>
        ///     "prompt": "Write a short poem about the weather."<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2024-04-23T19:36:28.355Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/25s2s4n7rdrgg0cf1httb3myk0/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/25s2s4n7rdrgg0cf1httb3myk0"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.<br/>
        /// All input parameters, output values, and logs are automatically removed after an hour, by default, for predictions created through the API.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PredictionResponse> CreatePredictionsModelsAsync(
            string modelOwner,
            string modelName,
            global::G.PredictionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreatePredictionsModelsArguments(
                httpClient: _httpClient,
                modelOwner: ref modelOwner,
                modelName: ref modelName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelOwner}/{modelName}/predictions",
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
            PrepareCreatePredictionsModelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelOwner: modelOwner,
                modelName: modelName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreatePredictionsModelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreatePredictionsModelsResponseContent(
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
                global::G.PredictionResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a prediction using an official model<br/>
        /// Start a new prediction for an official model using the inputs you provide.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "input": {<br/>
        ///     "prompt": "Write a short poem about the weather."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"input": {"prompt": "Write a short poem about the weather."}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/models/meta/meta-llama-3-70b-instruct/predictions<br/>
        /// ```<br/>
        /// The response will be the prediction object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "25s2s4n7rdrgg0cf1httb3myk0",<br/>
        ///   "model": "replicate-internal/llama3-70b-chat-vllm-unquantized",<br/>
        ///   "version": "dp-cf04fe09351e25db628e8b6181276547",<br/>
        ///   "input": {<br/>
        ///     "prompt": "Write a short poem about the weather."<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2024-04-23T19:36:28.355Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/25s2s4n7rdrgg0cf1httb3myk0/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/25s2s4n7rdrgg0cf1httb3myk0"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.<br/>
        /// All input parameters, output values, and logs are automatically removed after an hour, by default, for predictions created through the API.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="input">
        /// The model's input as a JSON object. The input schema depends on what model you are running. To see the available inputs, click the "API" tab on the model you are running or [get the model version](#models.versions.get) and look at its `openapi_schema` property. For example, [stability-ai/sdxl](https://replicate.com/stability-ai/sdxl) takes `prompt` as an input.<br/>
        /// Files should be passed as HTTP URLs or data URLs.<br/>
        /// Use an HTTP URL when:<br/>
        /// - you have a large file &gt; 256kb<br/>
        /// - you want to be able to use the file multiple times<br/>
        /// - you want your prediction metadata to be associable with your input files<br/>
        /// Use a data URL when:<br/>
        /// - you have a small file &lt;= 256kb<br/>
        /// - you don't want to upload and host the file somewhere<br/>
        /// - you don't need to use the file again (Replicate will not store it)
        /// </param>
        /// <param name="stream">
        /// **This field is deprecated.**<br/>
        /// Request a URL to receive streaming output using [server-sent events (SSE)](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events).<br/>
        /// This field is no longer needed as the returned prediction will always have a `stream` entry in its `url` property if the model supports streaming.
        /// </param>
        /// <param name="webhook">
        /// An HTTPS URL for receiving a webhook when the prediction has new output. The webhook will be a POST request where the request body is the same as the response body of the [get prediction](#predictions.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.
        /// </param>
        /// <param name="webhookEventsFilter">
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the prediction has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the prediction request:<br/>
        /// - `start`: immediately on prediction start<br/>
        /// - `output`: each time a prediction generates an output (note that predictions can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a prediction<br/>
        /// - `completed`: when the prediction reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the prediction, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        ///   "webhook_events_filter": ["start", "completed"]<br/>
        /// }<br/>
        /// ```<br/>
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PredictionResponse> CreatePredictionsModelsAsync(
            string modelOwner,
            string modelName,
            object input,
            bool? stream = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.PredictionRequestWebhookEventsFilterItem>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PredictionRequest
            {
                Input = input,
                Stream = stream,
                Webhook = webhook,
                WebhookEventsFilter = webhookEventsFilter,
            };

            return await CreatePredictionsModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}