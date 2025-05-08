//HintName: G.Models.CreateEvalRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalRequest
    {
        /// <summary>
        /// The name of the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The configuration for the data source used for the evaluation runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig> DataSourceConfig { get; set; }

        /// <summary>
        /// A list of graders for all eval runs in this group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalLabelModelGrader, global::G.EvalStringCheckGrader, global::G.EvalTextSimilarityGrader, global::G.EvalPythonGrader, global::G.EvalScoreModelGrader>> TestingCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRequest" /> class.
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
        /// The configuration for the data source used for the evaluation runs.
        /// </param>
        /// <param name="testingCriteria">
        /// A list of graders for all eval runs in this group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalRequest(
            global::G.OneOf<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig> dataSourceConfig,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalLabelModelGrader, global::G.EvalStringCheckGrader, global::G.EvalTextSimilarityGrader, global::G.EvalPythonGrader, global::G.EvalScoreModelGrader>> testingCriteria,
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.DataSourceConfig = dataSourceConfig;
            this.TestingCriteria = testingCriteria ?? throw new global::System.ArgumentNullException(nameof(testingCriteria));
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRequest" /> class.
        /// </summary>
        public CreateEvalRequest()
        {
        }
    }
}