//HintName: G.Models.TokenUsageNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenUsageNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        public global::System.Collections.Generic.IList<string>? Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsageNames" /> class.
        /// </summary>
        /// <param name="names"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenUsageNames(
            global::System.Collections.Generic.IList<string>? names)
        {
            this.Names = names;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsageNames" /> class.
        /// </summary>
        public TokenUsageNames()
        {
        }
    }
}