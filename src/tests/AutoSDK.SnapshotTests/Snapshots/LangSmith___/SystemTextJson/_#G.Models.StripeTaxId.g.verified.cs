//HintName: G.Models.StripeTaxId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe tax ID.
    /// </summary>
    public sealed partial class StripeTaxId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeTaxId" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StripeTaxId(
            string value,
            string type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeTaxId" /> class.
        /// </summary>
        public StripeTaxId()
        {
        }
    }
}