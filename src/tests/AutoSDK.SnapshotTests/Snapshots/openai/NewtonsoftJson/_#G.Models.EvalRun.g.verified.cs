//HintName: G.Models.EvalRun.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A schema representing an evaluation run.
    /// </summary>
    public sealed partial class EvalRun
    {
        /// <summary>
        /// The type of the object. Always "eval.run".<br/>
        /// Default Value: eval.run
        /// </summary>
        /// <default>global::G.EvalRunObject.EvalRun</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EvalRunObject Object { get; set; } = global::G.EvalRunObject.EvalRun;

        /// <summary>
        /// Unique identifier for the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The identifier of the associated evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalId { get; set; } = default!;

        /// <summary>
        /// The status of the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The model that is evaluated, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The name of the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The URL to the rendered evaluation run report on the UI dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReportUrl { get; set; } = default!;

        /// <summary>
        /// Counters summarizing the outcomes of the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalRunResultCounts ResultCounts { get; set; } = default!;

        /// <summary>
        /// Usage statistics for each model during the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_model_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalRunPerModelUsageItem> PerModelUsage { get; set; } = default!;

        /// <summary>
        /// Results per testing criteria applied during the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_testing_criteria_results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalRunPerTestingCriteriaResult> PerTestingCriteriaResults { get; set; } = default!;

        /// <summary>
        /// Information about the run's data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource> DataSource { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; } = default!;

        /// <summary>
        /// An object representing an error response from the Eval API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalApiError Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of the object. Always "eval.run".<br/>
        /// Default Value: eval.run
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation run.
        /// </param>
        /// <param name="evalId">
        /// The identifier of the associated evaluation.
        /// </param>
        /// <param name="status">
        /// The status of the evaluation run.
        /// </param>
        /// <param name="model">
        /// The model that is evaluated, if applicable.
        /// </param>
        /// <param name="name">
        /// The name of the evaluation run.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </param>
        /// <param name="reportUrl">
        /// The URL to the rendered evaluation run report on the UI dashboard.
        /// </param>
        /// <param name="resultCounts">
        /// Counters summarizing the outcomes of the evaluation run.
        /// </param>
        /// <param name="perModelUsage">
        /// Usage statistics for each model during the evaluation run.
        /// </param>
        /// <param name="perTestingCriteriaResults">
        /// Results per testing criteria applied during the evaluation run.
        /// </param>
        /// <param name="dataSource">
        /// Information about the run's data source.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="error">
        /// An object representing an error response from the Eval API.
        /// </param>
        public EvalRun(
            string id,
            string evalId,
            string status,
            string model,
            string name,
            global::System.DateTimeOffset createdAt,
            string reportUrl,
            global::G.EvalRunResultCounts resultCounts,
            global::System.Collections.Generic.IList<global::G.EvalRunPerModelUsageItem> perModelUsage,
            global::System.Collections.Generic.IList<global::G.EvalRunPerTestingCriteriaResult> perTestingCriteriaResults,
            global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource> dataSource,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.EvalApiError error,
            global::G.EvalRunObject @object = global::G.EvalRunObject.EvalRun)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.ReportUrl = reportUrl ?? throw new global::System.ArgumentNullException(nameof(reportUrl));
            this.ResultCounts = resultCounts ?? throw new global::System.ArgumentNullException(nameof(resultCounts));
            this.PerModelUsage = perModelUsage ?? throw new global::System.ArgumentNullException(nameof(perModelUsage));
            this.PerTestingCriteriaResults = perTestingCriteriaResults ?? throw new global::System.ArgumentNullException(nameof(perTestingCriteriaResults));
            this.DataSource = dataSource;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        public EvalRun()
        {
        }
    }
}