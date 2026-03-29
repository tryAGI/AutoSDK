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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Human-readable details about the concern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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