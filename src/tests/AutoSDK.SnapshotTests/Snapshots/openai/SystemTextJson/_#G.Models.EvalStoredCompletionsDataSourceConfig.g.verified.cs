//HintName: G.Models.EvalStoredCompletionsDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A StoredCompletionsDataSourceConfig which specifies the metadata property of your stored completions query.<br/>
    /// This is usually metadata like `usecase=chatbot` or `prompt-version=v2`, etc.<br/>
    /// The schema returned by this data source config is used to defined what variables are available in your evals.<br/>
    /// `item` and `sample` are both defined when using this data source config.
    /// </summary>
    public sealed partial class EvalStoredCompletionsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::G.EvalStoredCompletionsDataSourceConfigType.StoredCompletions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalStoredCompletionsDataSourceConfigTypeJsonConverter))]
        public global::G.EvalStoredCompletionsDataSourceConfigType Type { get; set; } = global::G.EvalStoredCompletionsDataSourceConfigType.StoredCompletions;

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
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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