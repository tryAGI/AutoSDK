//HintName: G.Models.AnswerResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerResult
    {
        /// <summary>
        /// The generated answer based on search results.<br/>
        /// Example: $350 billion.
        /// </summary>
        /// <example>$350 billion.</example>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Search results used to generate the answer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::System.Collections.Generic.IList<global::G.AnswerCitation>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResult" /> class.
        /// </summary>
        /// <param name="answer">
        /// The generated answer based on search results.<br/>
        /// Example: $350 billion.
        /// </param>
        /// <param name="citations">
        /// Search results used to generate the answer.
        /// </param>
        public AnswerResult(
            string? answer,
            global::System.Collections.Generic.IList<global::G.AnswerCitation>? citations)
        {
            this.Answer = answer;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResult" /> class.
        /// </summary>
        public AnswerResult()
        {
        }
    }
}