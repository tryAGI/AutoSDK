//HintName: G.Models.EvalStoredCompletionsDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated in favor of LogsDataSourceConfig.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvalStoredCompletionsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::G.EvalStoredCompletionsDataSourceConfigType.StoredCompletions</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EvalStoredCompletionsDataSourceConfigType Type { get; set; } = global::G.EvalStoredCompletionsDataSourceConfigType.StoredCompletions;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="schema">
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </param>
        public EvalStoredCompletionsDataSourceConfig(
            object schema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.EvalStoredCompletionsDataSourceConfigType type = global::G.EvalStoredCompletionsDataSourceConfigType.StoredCompletions)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        public EvalStoredCompletionsDataSourceConfig()
        {
        }
    }
}