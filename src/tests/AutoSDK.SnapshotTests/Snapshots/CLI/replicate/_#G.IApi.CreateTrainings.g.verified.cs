﻿//HintName: G.IApi.CreateTrainings.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
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
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            global::G.TrainingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
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
        /// <param name="destination">
        /// A string representing the desired model to push to in the format `{destination_model_owner}/{destination_model_name}`. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response.
        /// </param>
        /// <param name="input">
        /// An object containing inputs to the Cog model's `train()` function.
        /// </param>
        /// <param name="webhook">
        /// An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.
        /// </param>
        /// <param name="webhookEventsFilter">
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the training has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the training request:<br/>
        /// - `start`: immediately on training start<br/>
        /// - `output`: each time a training generates an output (note that trainings can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a training<br/>
        /// - `completed`: when the training reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the training, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "destination": "my-organization/my-model",<br/>
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
        global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            string destination,
            object input,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilterItem>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}