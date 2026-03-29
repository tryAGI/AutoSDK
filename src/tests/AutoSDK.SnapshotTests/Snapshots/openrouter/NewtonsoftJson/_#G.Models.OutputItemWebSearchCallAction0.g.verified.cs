//HintName: G.Models.OutputItemWebSearchCallAction0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemWebSearchCallAction0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputItemWebSearchCallActionOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources")]
        public global::System.Collections.Generic.IList<global::G.OutputItemWebSearchCallActionOneOf0SourcesItems>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallAction0" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="type"></param>
        /// <param name="queries"></param>
        /// <param name="sources"></param>
        public OutputItemWebSearchCallAction0(
            string query,
            global::G.OutputItemWebSearchCallActionOneOf0Type type,
            global::System.Collections.Generic.IList<string>? queries,
            global::System.Collections.Generic.IList<global::G.OutputItemWebSearchCallActionOneOf0SourcesItems>? sources)
        {
            this.Type = type;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Queries = queries;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallAction0" /> class.
        /// </summary>
        public OutputItemWebSearchCallAction0()
        {
        }
    }
}