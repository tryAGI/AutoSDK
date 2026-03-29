//HintName: G.Models.QuestionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionResponse
    {
        /// <summary>
        /// The question that was asked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// The answer to the question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Source> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subqueries")]
        public global::System.Collections.Generic.IList<global::G.SubQuery>? Subqueries { get; set; }

        /// <summary>
        /// Detailed source information organized by reference type, providing comprehensive metadata about the sources used to generate the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::G.References? References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionResponse" /> class.
        /// </summary>
        /// <param name="question">
        /// The question that was asked.
        /// </param>
        /// <param name="answer">
        /// The answer to the question.
        /// </param>
        /// <param name="sources"></param>
        /// <param name="subqueries"></param>
        /// <param name="references">
        /// Detailed source information organized by reference type, providing comprehensive metadata about the sources used to generate the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionResponse(
            string question,
            string answer,
            global::System.Collections.Generic.IList<global::G.Source> sources,
            global::System.Collections.Generic.IList<global::G.SubQuery>? subqueries,
            global::G.References? references)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Subqueries = subqueries;
            this.References = references;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionResponse" /> class.
        /// </summary>
        public QuestionResponse()
        {
        }
    }
}