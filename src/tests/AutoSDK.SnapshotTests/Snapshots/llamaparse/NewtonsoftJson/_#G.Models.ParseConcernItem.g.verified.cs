//HintName: G.Models.ParseConcernItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseConcernItem
    {
        /// <summary>
        /// Type of parse concern (e.g. header_value_type_mismatch, inconsistent_row_cell_count)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Human-readable details about the concern
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public string Details { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConcernItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of parse concern (e.g. header_value_type_mismatch, inconsistent_row_cell_count)
        /// </param>
        /// <param name="details">
        /// Human-readable details about the concern
        /// </param>
        public ParseConcernItem(
            string type,
            string details)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConcernItem" /> class.
        /// </summary>
        public ParseConcernItem()
        {
        }
    }
}