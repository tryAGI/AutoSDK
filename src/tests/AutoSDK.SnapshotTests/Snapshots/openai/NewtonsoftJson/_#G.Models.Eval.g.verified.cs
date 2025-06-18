//HintName: G.Models.Eval.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An Eval object with a data source config and testing criteria.<br/>
    /// An Eval represents a task to be done for your LLM integration.<br/>
    /// Like:<br/>
    ///  - Improve the quality of my chatbot<br/>
    ///  - See how well my chatbot handles customer support<br/>
    ///  - Check if o4-mini is better at my usecase than gpt-4o
    /// </summary>
    public sealed partial class Eval
    {
        /// <summary>
        /// The object type.<br/>
        /// Default Value: eval
        /// </summary>
        /// <default>global::G.EvalObject.Eval</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EvalObject Object { get; set; } = global::G.EvalObject.Eval;

        /// <summary>
        /// Unique identifier for the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the evaluation.<br/>
        /// Example: Chatbot effectiveness Evaluation
        /// </summary>
        /// <example>Chatbot effectiveness Evaluation</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Configuration of data sources used in runs of the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalCustomDataSourceConfig, global::G.EvalLogsDataSourceConfig, global::G.EvalStoredCompletionsDataSourceConfig> DataSourceConfig { get; set; } = default!;

        /// <summary>
        /// A list of testing criteria.<br/>
        /// Default Value: eval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testing_criteria", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.EvalGraderLabelModel?, global::G.EvalGraderStringCheck?, global::G.EvalGraderTextSimilarity?, global::G.EvalGraderPython?, global::G.EvalGraderScoreModel?>> TestingCriteria { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the eval was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Default Value: eval
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation.
        /// </param>
        /// <param name="name">
        /// The name of the evaluation.<br/>
        /// Example: Chatbot effectiveness Evaluation
        /// </param>
        /// <param name="dataSourceConfig">
        /// Configuration of data sources used in runs of the evaluation.
        /// </param>
        /// <param name="testingCriteria">
        /// A list of testing criteria.<br/>
        /// Default Value: eval
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the eval was created.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public Eval(
            string id,
            string name,
            global::G.OneOf<global::G.EvalCustomDataSourceConfig, global::G.EvalLogsDataSourceConfig, global::G.EvalStoredCompletionsDataSourceConfig> dataSourceConfig,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EvalGraderLabelModel?, global::G.EvalGraderStringCheck?, global::G.EvalGraderTextSimilarity?, global::G.EvalGraderPython?, global::G.EvalGraderScoreModel?>> testingCriteria,
            global::System.DateTimeOffset createdAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.EvalObject @object = global::G.EvalObject.Eval)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataSourceConfig = dataSourceConfig;
            this.TestingCriteria = testingCriteria ?? throw new global::System.ArgumentNullException(nameof(testingCriteria));
            this.CreatedAt = createdAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        public Eval()
        {
        }
    }
}