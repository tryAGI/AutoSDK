//HintName: G.Models.InputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input token usage details.
    /// </summary>
    public sealed partial class InputTokens
    {
        /// <summary>
        /// Number of input tokens consumed.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokens" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of input tokens consumed.<br/>
        /// Example: 120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputTokens(
            long? count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokens" /> class.
        /// </summary>
        public InputTokens()
        {
        }
    }
}