//HintName: G.Models.BetaRequestPageLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestPageLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaRequestPageLocationCitationTypeJsonConverter))]
        public global::G.BetaRequestPageLocationCitationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartPageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndPageNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestPageLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="type"></param>
        /// <param name="documentTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestPageLocationCitation(
            string citedText,
            int documentIndex,
            int startPageNumber,
            int endPageNumber,
            global::G.BetaRequestPageLocationCitationType type,
            string? documentTitle)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestPageLocationCitation" /> class.
        /// </summary>
        public BetaRequestPageLocationCitation()
        {
        }
    }
}