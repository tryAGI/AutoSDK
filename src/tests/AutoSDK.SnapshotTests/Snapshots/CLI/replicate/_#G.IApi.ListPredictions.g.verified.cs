//HintName: G.IApi.ListPredictions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List predictions<br/>
        /// Get a paginated list of predictions that you've created. This will include predictions created from the API and the website. It will return 100 records per page.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/predictions<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "completed_at": "2023-09-08T16:19:34.791859Z",<br/>
        ///       "created_at": "2023-09-08T16:19:34.907244Z",<br/>
        ///       "data_removed": false,<br/>
        ///       "error": null,<br/>
        ///       "id": "gm3qorzdhgbfurvjtvhg6dckhu",<br/>
        ///       "input": {<br/>
        ///         "text": "Alice"<br/>
        ///       },<br/>
        ///       "metrics": {<br/>
        ///         "predict_time": 0.012683<br/>
        ///       },<br/>
        ///       "output": "hello Alice",<br/>
        ///       "started_at": "2023-09-08T16:19:34.779176Z",<br/>
        ///       "source": "api",<br/>
        ///       "status": "succeeded",<br/>
        ///       "urls": {<br/>
        ///         "get": "https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu",<br/>
        ///         "cancel": "https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel"<br/>
        ///       },<br/>
        ///       "model": "replicate/hello-world",<br/>
        ///       "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// `id` will be the unique ID of the prediction.<br/>
        /// `source` will indicate how the prediction was created. Possible values are `web` or `api`.<br/>
        /// `status` will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.<br/>
        /// `urls` will be a convenience object that can be used to construct new API requests for the given prediction. If the requested model version supports streaming, this will have a `stream` entry with an HTTPS URL that you can use to construct an [`EventSource`](https://developer.mozilla.org/en-US/docs/Web/API/EventSource).<br/>
        /// `model` will be the model identifier string in the format of `{model_owner}/{model_name}`.<br/>
        /// `version` will be the unique ID of model version used to create the prediction.<br/>
        /// `data_removed` will be `true` if the input and output data has been deleted.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ListPredictionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}