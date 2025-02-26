//HintName: G.Models.ResponseCharLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseCharLocationCitation
    {
        /// <summary>
        /// Default Value: char_location
        /// </summary>
        /// <default>global::G.ResponseCharLocationCitationType.CharLocation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseCharLocationCitationType Type { get; set; } = global::G.ResponseCharLocationCitationType.CharLocation;

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
        [global::Newtonsoft.Json.JsonProperty("document_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DocumentTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartCharIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndCharIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCharLocationCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: char_location
        /// </param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="endCharIndex"></param>
        public ResponseCharLocationCitation(
            string citedText,
            int documentIndex,
            string? documentTitle,
            int startCharIndex,
            int endCharIndex,
            global::G.ResponseCharLocationCitationType type = global::G.ResponseCharLocationCitationType.CharLocation)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle ?? throw new global::System.ArgumentNullException(nameof(documentTitle));
            this.StartCharIndex = startCharIndex;
            this.EndCharIndex = endCharIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCharLocationCitation" /> class.
        /// </summary>
        public ResponseCharLocationCitation()
        {
        }
    }
}