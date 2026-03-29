//HintName: G.Models.FactualityRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FactualityRequest
    {
        /// <summary>
        /// The reference text for comparison.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// The text to be checked for factuality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityRequest" /> class.
        /// </summary>
        /// <param name="reference">
        /// The reference text for comparison.
        /// </param>
        /// <param name="text">
        /// The text to be checked for factuality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FactualityRequest(
            string reference,
            string text)
        {
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityRequest" /> class.
        /// </summary>
        public FactualityRequest()
        {
        }
    }
}