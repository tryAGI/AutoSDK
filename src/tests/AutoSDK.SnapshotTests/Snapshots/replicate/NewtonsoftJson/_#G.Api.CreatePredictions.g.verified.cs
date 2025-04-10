//HintName: G.Api.CreatePredictions.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreatePredictionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? prefer,
            global::G.VersionPredictionRequest request);
        partial void PrepareCreatePredictionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? prefer,
            global::G.VersionPredictionRequest request);
        partial void ProcessCreatePredictionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create a prediction<br/>
        /// Create a prediction for the model version and inputs you provide.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST -H 'Prefer: wait' \<br/>
        ///   -d '{"version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa", "input": {"text": "Alice"}}' \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/predictions<br/>
        /// ```<br/>
        /// The request will wait up to 60 seconds for the model to run. If this time is exceeded the prediction will be returned in a `"starting"` state and need to be retrieved using the `predictions.get` endpiont.<br/>
        /// For a complete overview of the `predictions.create` API check out our documentation on [creating a prediction](https://replicate.com/docs/topics/predictions/create-a-prediction) which covers a variety of use cases.
        /// </summary>
        /// <param name="prefer">
        /// Example: wait=5
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreatePredictionsAsync(
            global::G.VersionPredictionRequest request,
            string? prefer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePredictionsArguments(
                httpClient: HttpClient,
                prefer: ref prefer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/predictions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (prefer != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Prefer", prefer.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreatePredictionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                prefer: prefer,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreatePredictionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

            }
        }

        /// <summary>
        /// Create a prediction<br/>
        /// Create a prediction for the model version and inputs you provide.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST -H 'Prefer: wait' \<br/>
        ///   -d '{"version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa", "input": {"text": "Alice"}}' \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/predictions<br/>
        /// ```<br/>
        /// The request will wait up to 60 seconds for the model to run. If this time is exceeded the prediction will be returned in a `"starting"` state and need to be retrieved using the `predictions.get` endpiont.<br/>
        /// For a complete overview of the `predictions.create` API check out our documentation on [creating a prediction](https://replicate.com/docs/topics/predictions/create-a-prediction) which covers a variety of use cases.
        /// </summary>
        /// <param name="prefer">
        /// Example: wait=5
        /// </param>
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
        /// <param name="version">
        /// The ID of the model version that you want to run.
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
        ///   "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
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
        public async global::System.Threading.Tasks.Task CreatePredictionsAsync(
            object input,
            string version,
            string? prefer = default,
            bool? stream = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.VersionPredictionRequestWebhookEventsFilterItem>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.VersionPredictionRequest
            {
                Input = input,
                Stream = stream,
                Version = version,
                Webhook = webhook,
                WebhookEventsFilter = webhookEventsFilter,
            };

            await CreatePredictionsAsync(
                prefer: prefer,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}