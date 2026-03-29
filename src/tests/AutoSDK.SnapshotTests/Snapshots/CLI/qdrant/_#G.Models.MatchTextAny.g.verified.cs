//HintName: G.Models.MatchTextAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full-text match of at least one token of the string.
    /// </summary>
    public sealed partial class MatchTextAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_any")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextAny { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTextAny" /> class.
        /// </summary>
        /// <param name="textAny"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchTextAny(
            string textAny)
        {
            this.TextAny = textAny ?? throw new global::System.ArgumentNullException(nameof(textAny));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTextAny" /> class.
        /// </summary>
        public MatchTextAny()
        {
        }
    }
}