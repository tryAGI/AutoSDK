//HintName: G.Models.NumberAnalysisData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumberAnalysisData
    {
        /// <summary>
        /// Type of the variable to extract.<br/>
        /// Example: number
        /// </summary>
        /// <example>number</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.NumberAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: order_count
        /// </summary>
        /// <example>order_count</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: How many the customer intend to order.
        /// </summary>
        /// <example>How many the customer intend to order.</example>
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
        /// Initializes a new instance of the <see cref="NumberAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the variable.<br/>
        /// Example: order_count
        /// </param>
        /// <param name="description">
        /// Description of the variable.<br/>
        /// Example: How many the customer intend to order.
        /// </param>
        /// <param name="type">
        /// Type of the variable to extract.<br/>
        /// Example: number
        /// </param>
        /// <param name="required">
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </param>
        public NumberAnalysisData(
            string name,
            string description,
            global::G.NumberAnalysisDataType type,
            bool? required)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberAnalysisData" /> class.
        /// </summary>
        public NumberAnalysisData()
        {
        }
    }
}