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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StringAnalysisDataTypeJsonConverter))]
        public global::G.StringAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: customer_name
        /// </summary>
        /// <example>customer_name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: The name of the customer.
        /// </summary>
        /// <example>The name of the customer.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Examples of the variable value to teach model the style and syntax.<br/>
        /// Example: [John Doe, Jane Smith]
        /// </summary>
        /// <example>[John Doe, Jane Smith]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<string>? Examples { get; set; }

        /// <summary>
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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