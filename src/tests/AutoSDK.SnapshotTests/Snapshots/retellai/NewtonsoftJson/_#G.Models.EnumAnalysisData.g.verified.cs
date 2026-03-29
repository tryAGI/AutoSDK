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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EnumAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: product_rating
        /// </summary>
        /// <example>product_rating</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: Rating of the product.
        /// </summary>
        /// <example>Rating of the product.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The possible values of the variable, must be non empty array.<br/>
        /// Example: [good]
        /// </summary>
        /// <example>[good]</example>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Choices { get; set; } = default!;

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