//HintName: G.Models.StringAnalysisData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StringAnalysisData
    {
        /// <summary>
        /// Type of the variable to extract.<br/>
        /// Example: string
        /// </summary>
        /// <example>string</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StringAnalysisDataTypeJsonConverter))]
        public global::G.StringAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: customer_name
        /// </summary>
        /// <example>customer_name</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: The name of the customer.
        /// </summary>
        /// <example>The name of the customer.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Examples of the variable value to teach model the style and syntax.<br/>
        /// Example: [John Doe, Jane Smith]
        /// </summary>
        /// <example>[John Doe, Jane Smith]</example>
        [global::Newtonsoft.Json.JsonProperty("examples")]
        public global::System.Collections.Generic.IList<string>? Examples { get; set; }

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
        /// Initializes a new instance of the <see cref="StringAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the variable.<br/>
        /// Example: customer_name
        /// </param>
        /// <param name="description">
        /// Description of the variable.<br/>
        /// Example: The name of the customer.
        /// </param>
        /// <param name="type">
        /// Type of the variable to extract.<br/>
        /// Example: string
        /// </param>
        /// <param name="examples">
        /// Examples of the variable value to teach model the style and syntax.<br/>
        /// Example: [John Doe, Jane Smith]
        /// </param>
        /// <param name="required">
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </param>
        public StringAnalysisData(
            string name,
            string description,
            global::G.StringAnalysisDataType type,
            global::System.Collections.Generic.IList<string>? examples,
            bool? required)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Examples = examples;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringAnalysisData" /> class.
        /// </summary>
        public StringAnalysisData()
        {
        }
    }
}