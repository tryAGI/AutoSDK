//HintName: G.Models.CreateEvalStoredCompletionsDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated in favor of LogsDataSourceConfig.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateEvalStoredCompletionsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::G.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CreateEvalStoredCompletionsDataSourceConfigType Type { get; set; } = global::G.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions;

        /// <summary>
        /// Metadata filters for the stored completions data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
        /// <param name="metadata">
        /// Metadata filters for the stored completions data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </param>
        public CreateEvalStoredCompletionsDataSourceConfig(
            object? metadata,
            global::G.CreateEvalStoredCompletionsDataSourceConfigType type = global::G.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        public CreateEvalStoredCompletionsDataSourceConfig()
        {
        }
    }
}