//HintName: G.Api.GetPredictions.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGetPredictionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string predictionId);
        partial void PrepareGetPredictionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string predictionId);
        partial void ProcessGetPredictionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessGetPredictionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a prediction<br/>
        /// Get the current state of a prediction.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu<br/>
        /// ```<br/>
        /// The response will be the prediction object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "gm3qorzdhgbfurvjtvhg6dckhu",<br/>
        ///   "model": "replicate/hello-world",<br/>
        ///   "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "logs": "",<br/>
        ///   "output": "hello Alice",<br/>
        ///   "error": null,<br/>
        ///   "status": "succeeded",<br/>
        ///   "created_at": "2023-09-08T16:19:34.765994Z",<br/>
        ///   "started_at": "2023-09-08T16:19:34.779176Z",<br/>
        ///   "completed_at": "2023-09-08T16:19:34.791859Z",<br/>
        ///   "metrics": {<br/>
        ///     "predict_time": 0.012683<br/>
        ///   },<br/>
        ///   "urls": {<br/>
        ///     "cancel": "https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel",<br/>
        ///     "get": "https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `status` will be one of:<br/>
        /// - `starting`: the prediction is starting up. If this status lasts longer than a few seconds, then it's typically because a new worker is being started to run the prediction.<br/>
        /// - `processing`: the `predict()` method of the model is currently running.<br/>
        /// - `succeeded`: the prediction completed successfully.<br/>
        /// - `failed`: the prediction encountered an error during processing.<br/>
        /// - `canceled`: the prediction was canceled by its creator.<br/>
        /// In the case of success, `output` will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You'll need to pass the `Authorization` header to request them.<br/>
        /// In the case of failure, `error` will contain the error encountered during the prediction.<br/>
        /// Terminated predictions (with a status of `succeeded`, `failed`, or `canceled`) will include a `metrics` object with a `predict_time` property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won't include time waiting for the prediction to start.<br/>
        /// Input and output (including any files) are automatically deleted after an hour, so you must save a copy of any files in the output if you'd like to continue using them.<br/>
        /// Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.
        /// </summary>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task GetPredictionsAsync(
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/predictions/{predictionId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}