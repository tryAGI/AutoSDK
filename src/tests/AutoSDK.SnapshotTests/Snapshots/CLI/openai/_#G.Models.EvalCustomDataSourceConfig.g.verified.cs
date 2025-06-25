//HintName: G.Models.EvalCustomDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CustomDataSourceConfig which specifies the schema of your `item` and optionally `sample` namespaces.<br/>
    /// The response schema defines the shape of the data that will be:<br/>
    /// - Used to define your testing criteria and<br/>
    /// - What data is required when creating a run
    /// </summary>
    public sealed partial class EvalCustomDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>global::G.EvalCustomDataSourceConfigType.Custom</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalCustomDataSourceConfigTypeJsonConverter))]
        public global::G.EvalCustomDataSourceConfigType Type { get; set; } = global::G.EvalCustomDataSourceConfigType.Custom;

        /// <summary>
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "item": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "label": {"type": "string"},<br/>
        ///       },<br/>
        ///       "required": ["label"]<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "required": ["item"]<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "item": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "label": {"type": "string"},<br/>
        ///       },<br/>
        ///       "required": ["label"]<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "required": ["item"]<br/>
        /// }
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalCustomDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </param>
        /// <param name="schema">
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "item": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "label": {"type": "string"},<br/>
        ///       },<br/>
        ///       "required": ["label"]<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "required": ["item"]<br/>
        /// }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalCustomDataSourceConfig(
            object schema,
            global::G.EvalCustomDataSourceConfigType type = global::G.EvalCustomDataSourceConfigType.Custom)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalCustomDataSourceConfig" /> class.
        /// </summary>
        public EvalCustomDataSourceConfig()
        {
        }
    }
}