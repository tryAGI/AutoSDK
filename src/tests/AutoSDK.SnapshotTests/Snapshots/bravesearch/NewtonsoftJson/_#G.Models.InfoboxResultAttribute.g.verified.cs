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
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Attribute value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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