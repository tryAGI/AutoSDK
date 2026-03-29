//HintName: G.Models.ReturnTts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnTts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generations")]
        public global::System.Collections.Generic.IList<global::G.ReturnGeneration>? Generations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippets")]
        public global::System.Collections.Generic.IList<global::G.Snippet>? Snippets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTts" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="generations"></param>
        /// <param name="snippets"></param>
        public ReturnTts(
            string? generationId,
            global::System.Collections.Generic.IList<global::G.ReturnGeneration>? generations,
            global::System.Collections.Generic.IList<global::G.Snippet>? snippets)
        {
            this.GenerationId = generationId;
            this.Generations = generations;
            this.Snippets = snippets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTts" /> class.
        /// </summary>
        public ReturnTts()
        {
        }
    }
}