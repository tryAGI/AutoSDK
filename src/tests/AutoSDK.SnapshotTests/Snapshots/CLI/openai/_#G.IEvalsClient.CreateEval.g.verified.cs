//HintName: G.IEvalsClient.CreateEval.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Create the structure of an evaluation that can be used to test a model's performance.<br/>
        /// An evaluation is a set of testing criteria and the config for a data source, which dictates the schema of the data used in the evaluation. After creating an evaluation, you can run it on different models and model parameters. We support several types of graders and datasources.<br/>
        /// For more information, see the [Evals guide](/docs/guides/evals).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Eval> CreateEvalAsync(
            global::G.CreateEvalRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create the structure of an evaluation that can be used to test a model's performance.<br/>
        /// An evaluation is a set of testing criteria and the config for a data source, which dictates the schema of the data used in the evaluation. After creating an evaluation, you can run it on different models and model parameters. We support several types of graders and datasources.<br/>
        /// For more information, see the [Evals guide](/docs/guides/evals).
        /// </summary>
        /// <param name="name">
        /// The name of the evaluation.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="dataSourceConfig">
        /// The configuration for the data source used for the evaluation runs. Dictates the schema of the data used in the evaluation.
        /// </param>
        /// <param name="testingCriteria">
        /// A list of graders for all eval runs in this group. Graders can reference variables in the data source using double curly braces notation, like `{{item.variable_name}}`. To reference the model's output, use the `sample` namespace (ie, `{{sample.output_text}}`).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Eval> CreateEvalAsync(
#pragma warning disable CS0618 // Type or member is obsolete
            global::G.OneOf<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig, global::G.CreateEvalStoredCompletionsDataSourceConfig> dataSourceConfig,
#pragma warning disable CS0618 // Type or member is obsolete
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalLabelModelGrader, global::G.EvalGraderStringCheck?, global::G.EvalGraderTextSimilarity?, global::G.EvalGraderPython?, global::G.EvalGraderScoreModel?>> testingCriteria,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}