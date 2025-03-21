//HintName: G.Models.LogProbVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogProbVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<global::G.LogProbProperties>? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProbVariant2" /> class.
        /// </summary>
        /// <param name="topLogprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogProbVariant2(
            global::System.Collections.Generic.IList<global::G.LogProbProperties>? topLogprobs)
        {
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProbVariant2" /> class.
        /// </summary>
        public LogProbVariant2()
        {
        }
    }
}