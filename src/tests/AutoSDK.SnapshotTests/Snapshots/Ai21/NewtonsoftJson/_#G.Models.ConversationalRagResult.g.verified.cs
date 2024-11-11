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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Message> Choices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_queries")]
        public global::System.Collections.Generic.IList<string>? SearchQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_retrieved", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ContextRetrieved { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer_in_context", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AnswerInContext { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationalRagSource> Sources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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