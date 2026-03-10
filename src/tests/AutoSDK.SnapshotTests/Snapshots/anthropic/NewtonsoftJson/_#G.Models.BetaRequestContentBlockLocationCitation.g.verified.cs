//HintName: G.Models.BetaRequestContentBlockLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestContentBlockLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRequestContentBlockLocationCitationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cited_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string CitedText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int DocumentIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_block_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartBlockIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_block_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndBlockIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestContentBlockLocationCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="endBlockIndex"></param>
        public BetaRequestContentBlockLocationCitation(
            string citedText,
            int documentIndex,
            int startBlockIndex,
            int endBlockIndex,
            global::G.BetaRequestContentBlockLocationCitationType type,
            string? documentTitle)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.StartBlockIndex = startBlockIndex;
            this.EndBlockIndex = endBlockIndex;
            this.Type = type;
            this.DocumentTitle = documentTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestContentBlockLocationCitation" /> class.
        /// </summary>
        public BetaRequestContentBlockLocationCitation()
        {
        }
    }
}