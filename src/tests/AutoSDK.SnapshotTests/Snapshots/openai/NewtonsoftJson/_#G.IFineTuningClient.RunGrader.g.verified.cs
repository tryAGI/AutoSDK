//HintName: G.IFineTuningClient.RunGrader.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Run a grader.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunGraderResponse> RunGraderAsync(
            global::G.RunGraderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run a grader.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="item">
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
        /// </param>
        /// <param name="modelSample">
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunGraderResponse> RunGraderAsync(
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            string modelSample,
            object? item = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}