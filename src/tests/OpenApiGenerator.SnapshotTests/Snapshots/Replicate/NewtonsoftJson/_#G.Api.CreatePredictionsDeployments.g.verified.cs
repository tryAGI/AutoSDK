//HintName: G.Api.CreatePredictionsDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a prediction using a deployment<br/>
        /// Start a new prediction for a deployment of a model using inputs you provide.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"input": {"text": "Alice"}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   "https://api.replicate.com/v1/deployments/replicate/hello-world/predictions"<br/>
        /// ```<br/>
        /// The response will be the prediction object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "86b6trbv99rgp0cf1h886f69ew",<br/>
        ///   "model": "replicate/hello-world",<br/>
        ///   "version": "dp-8e43d61c333b5ddc7a921130bc3ab3ea",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2024-04-23T18:55:52.138Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/86b6trbv99rgp0cf1h886f69ew/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/86b6trbv99rgp0cf1h886f69ew"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.<br/>
        /// Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you'd like to continue using them.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreatePredictionsDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
            global::G.PredictionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/deployments/{deploymentOwner}/{deploymentName}/predictions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
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
        /// Create a prediction using a deployment<br/>
        /// Start a new prediction for a deployment of a model using inputs you provide.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"input": {"text": "Alice"}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   "https://api.replicate.com/v1/deployments/replicate/hello-world/predictions"<br/>
        /// ```<br/>
        /// The response will be the prediction object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "86b6trbv99rgp0cf1h886f69ew",<br/>
        ///   "model": "replicate/hello-world",<br/>
        ///   "version": "dp-8e43d61c333b5ddc7a921130bc3ab3ea",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2024-04-23T18:55:52.138Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/86b6trbv99rgp0cf1h886f69ew/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/86b6trbv99rgp0cf1h886f69ew"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several seconds or more to run, the output will not be available immediately. To get the final result of the prediction you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a prediction](#predictions.get) endpoint until it has finished.<br/>
        /// Input and output (including any files) will be automatically deleted after an hour, so you must save a copy of any files in the output if you'd like to continue using them.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="input"></param>
        /// <param name="stream"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEventsFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreatePredictionsDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
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

            await CreatePredictionsDeploymentsAsync(
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}