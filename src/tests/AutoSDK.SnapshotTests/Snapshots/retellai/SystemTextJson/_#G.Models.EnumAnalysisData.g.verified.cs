//HintName: G.Models.EnumAnalysisData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnumAnalysisData
    {
        /// <summary>
        /// Type of the variable to extract.<br/>
        /// Example: enum
        /// </summary>
        /// <example>enum</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnumAnalysisDataTypeJsonConverter))]
        public global::G.EnumAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: product_rating
        /// </summary>
        /// <example>product_rating</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: Rating of the product.
        /// </summary>
        /// <example>Rating of the product.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The possible values of the variable, must be non empty array.<br/>
        /// Example: [good]
        /// </summary>
        /// <example>[good]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Choices { get; set; }

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
        /// Initializes a new instance of the <see cref="EnumAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the variable.<br/>
        /// Example: product_rating
        /// </param>
        /// <param name="description">
        /// Description of the variable.<br/>
        /// Example: Rating of the product.
        /// </param>
        /// <param name="choices">
        /// The possible values of the variable, must be non empty array.<br/>
        /// Example: [good]
        /// </param>
        /// <param name="type">
        /// Type of the variable to extract.<br/>
        /// Example: enum
        /// </param>
        /// <param name="required">
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnumAnalysisData(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> choices,
            global::G.EnumAnalysisDataType type,
            bool? required)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumAnalysisData" /> class.
        /// </summary>
        public EnumAnalysisData()
        {
        }
    }
}