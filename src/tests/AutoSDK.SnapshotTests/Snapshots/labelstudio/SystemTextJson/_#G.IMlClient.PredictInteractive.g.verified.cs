//HintName: G.IMlClient.PredictInteractive.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Request Interactive Annotation<br/>
        ///         Send a request to the machine learning backend set up to be used for interactive preannotations to retrieve a<br/>
        ///         predicted region based on annotator input. <br/>
        ///         See [set up machine learning](https://labelstud.io/guide/ml.html#Get-interactive-preannotations) for more.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PredictInteractiveAsync(
            int id,

            global::G.MLInteractiveAnnotatingRequestRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Interactive Annotation<br/>
        ///         Send a request to the machine learning backend set up to be used for interactive preannotations to retrieve a<br/>
        ///         predicted region based on annotator input. <br/>
        ///         See [set up machine learning](https://labelstud.io/guide/ml.html#Get-interactive-preannotations) for more.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context">
        /// Context for ML model
        /// </param>
        /// <param name="task">
        /// ID of task to annotate
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PredictInteractiveAsync(
            int id,
            int task,
            object? context = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}