//HintName: G.Api.CreateTrainings.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a training<br/>
        /// Start a new training of the model version you specify.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "destination": "{new_owner}/{new_name}",<br/>
        ///   "input": {<br/>
        ///     "train_data": "https://example.com/my-input-images.zip",<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"destination": "{new_owner}/{new_name}", "input": {"input_images": "https://example.com/my-input-images.zip"}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings<br/>
        /// ```<br/>
        /// The response will be the training object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "zz4ibbonubfz7carwiefibzgga",<br/>
        ///   "model": "stability-ai/sdxl",<br/>
        ///   "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///   "input": {<br/>
        ///     "input_images": "https://example.com/my-input-images.zip"<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2023-09-08T16:32:56.990893084Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.<br/>
        /// When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.<br/>
        /// To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            global::G.TrainingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/models/{modelOwner}/{modelName}/versions/{versionId}/trainings", global::System.UriKind.RelativeOrAbsolute));
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
        /// Create a training<br/>
        /// Start a new training of the model version you specify.<br/>
        /// Example request body:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "destination": "{new_owner}/{new_name}",<br/>
        ///   "input": {<br/>
        ///     "train_data": "https://example.com/my-input-images.zip",<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        /// }<br/>
        /// ```<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -d '{"destination": "{new_owner}/{new_name}", "input": {"input_images": "https://example.com/my-input-images.zip"}}' \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings<br/>
        /// ```<br/>
        /// The response will be the training object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "zz4ibbonubfz7carwiefibzgga",<br/>
        ///   "model": "stability-ai/sdxl",<br/>
        ///   "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///   "input": {<br/>
        ///     "input_images": "https://example.com/my-input-images.zip"<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "error": null,<br/>
        ///   "status": "starting",<br/>
        ///   "created_at": "2023-09-08T16:32:56.990893084Z",<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.<br/>
        /// When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.<br/>
        /// To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="destination"></param>
        /// <param name="input"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEventsFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            string destination,
            object input,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilter?>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TrainingRequest
            {
                Destination = destination,
                Input = input,
                Webhook = webhook,
                WebhookEventsFilter = webhookEventsFilter,
            };

            await CreateTrainingsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}