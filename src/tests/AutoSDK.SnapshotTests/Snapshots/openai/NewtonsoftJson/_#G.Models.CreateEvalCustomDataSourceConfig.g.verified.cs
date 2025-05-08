//HintName: G.Models.CreateEvalCustomDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CustomDataSourceConfig object that defines the schema for the data source used for the evaluation runs.<br/>
    /// This schema is used to define the shape of the data that will be:<br/>
    /// - Used to define your testing criteria and<br/>
    /// - What data is required when creating a run
    /// </summary>
    public sealed partial class CreateEvalCustomDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>global::G.CreateEvalCustomDataSourceConfigType.Custom</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalCustomDataSourceConfigType Type { get; set; } = global::G.CreateEvalCustomDataSourceConfigType.Custom;

        /// <summary>
        /// The json schema for each row in the data source.<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("item_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object ItemSchema { get; set; } = default!;

        /// <summary>
        /// Whether the eval should expect you to populate the sample namespace (ie, by generating responses off of your data source)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_sample_schema")]
        public bool? IncludeSampleSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCustomDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </param>
        /// <param name="itemSchema">
        /// The json schema for each row in the data source.<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </param>
        /// <param name="includeSampleSchema">
        /// Whether the eval should expect you to populate the sample namespace (ie, by generating responses off of your data source)<br/>
        /// Default Value: false
        /// </param>
        public CreateEvalCustomDataSourceConfig(
            object itemSchema,
            bool? includeSampleSchema,
            global::G.CreateEvalCustomDataSourceConfigType type = global::G.CreateEvalCustomDataSourceConfigType.Custom)
        {
            this.ItemSchema = itemSchema ?? throw new global::System.ArgumentNullException(nameof(itemSchema));
            this.Type = type;
            this.IncludeSampleSchema = includeSampleSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCustomDataSourceConfig" /> class.
        /// </summary>
        public CreateEvalCustomDataSourceConfig()
        {
        }
    }
}