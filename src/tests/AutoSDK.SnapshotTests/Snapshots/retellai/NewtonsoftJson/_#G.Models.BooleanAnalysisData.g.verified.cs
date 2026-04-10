//HintName: G.Models.BooleanAnalysisData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanAnalysisData
    {
        /// <summary>
        /// Type of the variable to extract.<br/>
        /// Example: boolean
        /// </summary>
        /// <example>boolean</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BooleanAnalysisDataTypeJsonConverter))]
        public global::G.BooleanAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: is_converted
        /// </summary>
        /// <example>is_converted</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: Whether the customer converted.
        /// </summary>
        /// <example>Whether the customer converted.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the variable.<br/>
        /// Example: is_converted
        /// </param>
        /// <param name="description">
        /// Description of the variable.<br/>
        /// Example: Whether the customer converted.
        /// </param>
        /// <param name="type">
        /// Type of the variable to extract.<br/>
        /// Example: boolean
        /// </param>
        /// <param name="required">
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </param>
        public BooleanAnalysisData(
            string name,
            string description,
            global::G.BooleanAnalysisDataType type,
            bool? required)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanAnalysisData" /> class.
        /// </summary>
        public BooleanAnalysisData()
        {
        }
    }
}