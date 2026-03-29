//HintName: G.Models.PayloadField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload field
    /// </summary>
    public sealed partial class PayloadField
    {
        /// <summary>
        /// Payload field name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadField" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload field name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayloadField(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadField" /> class.
        /// </summary>
        public PayloadField()
        {
        }
    }
}