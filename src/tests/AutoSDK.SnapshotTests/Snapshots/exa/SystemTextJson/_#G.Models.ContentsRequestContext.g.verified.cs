//HintName: G.Models.ContentsRequestContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Return page contents as a context string for LLM. When true, combines all result contents into one string. Context strings often perform better than highlights for LLMs.
    /// </summary>
    public sealed partial class ContentsRequestContext
    {
        /// <summary>
        /// Maximum character limit.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestContext" /> class.
        /// </summary>
        /// <param name="maxCharacters">
        /// Maximum character limit.<br/>
        /// Example: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestContext(
            int? maxCharacters)
        {
            this.MaxCharacters = maxCharacters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestContext" /> class.
        /// </summary>
        public ContentsRequestContext()
        {
        }
    }
}