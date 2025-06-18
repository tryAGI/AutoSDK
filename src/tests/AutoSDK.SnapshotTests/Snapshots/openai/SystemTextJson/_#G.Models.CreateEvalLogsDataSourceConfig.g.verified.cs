//HintName: G.Models.CreateEvalLogsDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A data source config which specifies the metadata property of your logs query.<br/>
    /// This is usually metadata like `usecase=chatbot` or `prompt-version=v2`, etc.
    /// </summary>
    public sealed partial class CreateEvalLogsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `logs`.<br/>
        /// Default Value: logs
        /// </summary>
        /// <default>global::G.CreateEvalLogsDataSourceConfigType.Logs</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalLogsDataSourceConfigTypeJsonConverter))]
        public global::G.CreateEvalLogsDataSourceConfigType Type { get; set; } = global::G.CreateEvalLogsDataSourceConfigType.Logs;

        /// <summary>
        /// Metadata filters for the logs data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLogsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `logs`.<br/>
        /// Default Value: logs
        /// </param>
        /// <param name="metadata">
        /// Metadata filters for the logs data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalLogsDataSourceConfig(
            object? metadata,
            global::G.CreateEvalLogsDataSourceConfigType type = global::G.CreateEvalLogsDataSourceConfigType.Logs)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLogsDataSourceConfig" /> class.
        /// </summary>
        public CreateEvalLogsDataSourceConfig()
        {
        }
    }
}