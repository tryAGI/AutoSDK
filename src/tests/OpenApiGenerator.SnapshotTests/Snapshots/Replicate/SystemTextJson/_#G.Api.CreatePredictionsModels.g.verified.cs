//HintName: G.Api.CreatePredictionsModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
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
        /// Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you'd like to continue using them.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreatePredictionsModelsAsync(
            string modelOwner,
            string modelName,
            global::G.PredictionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/models/{modelOwner}/{modelName}/predictions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
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
        /// Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you'd like to continue using them.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="input"></param>
        /// <param name="stream"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEventsFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreatePredictionsModelsAsync(
            string modelOwner,
            string modelName,
            object input,
            bool stream = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.PredictionRequestWebhookEventsFilter?>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PredictionRequest
            {
                Input = input,
                Stream = stream,
                Webhook = webhook,
                WebhookEventsFilter = webhookEventsFilter,
            };

            await CreatePredictionsModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}