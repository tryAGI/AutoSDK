//HintName: G.Models.InfoboxResultAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfoboxResultAttribute
    {
        /// <summary>
        /// Attribute label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Attribute value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResultAttribute" /> class.
        /// </summary>
        /// <param name="label">
        /// Attribute label.
        /// </param>
        /// <param name="value">
        /// Attribute value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoboxResultAttribute(
            string? label,
            string? value)
        {
            this.Label = label;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResultAttribute" /> class.
        /// </summary>
        public InfoboxResultAttribute()
        {
        }
    }
}