//HintName: G.Models.RephraseTextResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RephraseTextResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvements")]
        public global::System.Collections.Generic.IList<global::G.RephraseTextResponseImprovement>? Improvements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextResponse" /> class.
        /// </summary>
        /// <param name="improvements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RephraseTextResponse(
            global::System.Collections.Generic.IList<global::G.RephraseTextResponseImprovement>? improvements)
        {
            this.Improvements = improvements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextResponse" /> class.
        /// </summary>
        public RephraseTextResponse()
        {
        }
    }
}