//HintName: G.Models.AnswerResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerResponse3
    {
        /// <summary>
        /// Partial answer chunk when streaming is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::G.AnswerCitation>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse3" /> class.
        /// </summary>
        /// <param name="answer">
        /// Partial answer chunk when streaming is enabled.
        /// </param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResponse3(
            string? answer,
            global::System.Collections.Generic.IList<global::G.AnswerCitation>? citations)
        {
            this.Answer = answer;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse3" /> class.
        /// </summary>
        public AnswerResponse3()
        {
        }
    }
}