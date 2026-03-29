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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BooleanAnalysisDataTypeJsonConverter))]
        public global::G.BooleanAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: is_converted
        /// </summary>
        /// <example>is_converted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: Whether the customer converted.
        /// </summary>
        /// <example>Whether the customer converted.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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