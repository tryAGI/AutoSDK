//HintName: G.Models.TranscriptList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of transcripts. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
    /// </summary>
    public sealed partial class TranscriptList
    {
        /// <summary>
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageDetails PageDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcripts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptListItem> Transcripts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptList" /> class.
        /// </summary>
        /// <param name="pageDetails">
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </param>
        /// <param name="transcripts"></param>
        public TranscriptList(
            global::G.PageDetails pageDetails,
            global::System.Collections.Generic.IList<global::G.TranscriptListItem> transcripts)
        {
            this.PageDetails = pageDetails ?? throw new global::System.ArgumentNullException(nameof(pageDetails));
            this.Transcripts = transcripts ?? throw new global::System.ArgumentNullException(nameof(transcripts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptList" /> class.
        /// </summary>
        public TranscriptList()
        {
        }
    }
}