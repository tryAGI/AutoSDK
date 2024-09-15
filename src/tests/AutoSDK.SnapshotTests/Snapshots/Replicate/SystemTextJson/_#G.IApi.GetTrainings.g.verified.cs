//HintName: G.IApi.GetTrainings.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a training<br/>
        /// Get the current state of a training.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga<br/>
        /// ```<br/>
        /// The response will be the training object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "completed_at": "2023-09-08T16:41:19.826523Z",<br/>
        ///   "created_at": "2023-09-08T16:32:57.018467Z",<br/>
        ///   "error": null,<br/>
        ///   "id": "zz4ibbonubfz7carwiefibzgga",<br/>
        ///   "input": {<br/>
        ///     "input_images": "https://example.com/my-input-images.zip"<br/>
        ///   },<br/>
        ///   "logs": "...",<br/>
        ///   "metrics": {<br/>
        ///     "predict_time": 502.713876<br/>
        ///   },<br/>
        ///   "output": {<br/>
        ///     "version": "...",<br/>
        ///     "weights": "..."<br/>
        ///   },<br/>
        ///   "started_at": "2023-09-08T16:32:57.112647Z",<br/>
        ///   "status": "succeeded",<br/>
        ///   "urls": {<br/>
        ///     "get": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga",<br/>
        ///     "cancel": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel"<br/>
        ///   },<br/>
        ///   "model": "stability-ai/sdxl",<br/>
        ///   "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        /// }<br/>
        /// ```<br/>
        /// `status` will be one of:<br/>
        /// - `starting`: the training is starting up. If this status lasts longer than a few seconds, then it's typically because a new worker is being started to run the training.<br/>
        /// - `processing`: the `train()` method of the model is currently running.<br/>
        /// - `succeeded`: the training completed successfully.<br/>
        /// - `failed`: the training encountered an error during processing.<br/>
        /// - `canceled`: the training was canceled by its creator.<br/>
        /// In the case of success, `output` will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You'll need to pass the `Authorization` header to request them.<br/>
        /// In the case of failure, `error` will contain the error encountered during the training.<br/>
        /// Terminated trainings (with a status of `succeeded`, `failed`, or `canceled`) will include a `metrics` object with a `predict_time` property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won't include time waiting for the training to start.
        /// </summary>
        /// <param name="trainingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task GetTrainingsAsync(
            string trainingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}