//HintName: G.Models.ConversationalRagResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalRagResult
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Message> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries")]
        public global::System.Collections.Generic.IList<string>? SearchQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_retrieved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContextRetrieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_in_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AnswerInContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationalRagSource> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagResult" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="choices"></param>
        /// <param name="searchQueries"></param>
        /// <param name="contextRetrieved"></param>
        /// <param name="answerInContext"></param>
        /// <param name="sources"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationalRagResult(
            string id,
            global::System.Collections.Generic.IList<global::G.Message> choices,
            bool contextRetrieved,
            bool answerInContext,
            global::System.Collections.Generic.IList<global::G.ConversationalRagSource> sources,
            global::System.Collections.Generic.IList<string>? searchQueries)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.ContextRetrieved = contextRetrieved;
            this.AnswerInContext = answerInContext;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.SearchQueries = searchQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagResult" /> class.
        /// </summary>
        public ConversationalRagResult()
        {
        }
    }
}