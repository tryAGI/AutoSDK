//HintName: G.Models.TranscriptList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of transcripts. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.<br/>
    /// Example: {"page_details":{"limit":3,"result_count":3,"current_url":"https://api.assemblyai.com/v2/transcript?limit=3","prev_url":"https://api.assemblyai.com/v2/transcript?limit=3\u0026before_id=28a73d01-98db-41dd-9e98-2533ba0af117","next_url":"https://api.assemblyai.com/v2/transcript?limit=3\u0026after_id=b33f4691-85b7-4f31-be12-a87cef1c1229"},"transcripts":[{"id":"b33f4691-85b7-4f31-be12-a87cef1c1229","resource_url":"https://api.assemblyai.com/v2/transcript/b33f4691-85b7-4f31-be12-a87cef1c1229","status":"completed","created":"2024-03-11T21:29:59.9368510\u002B04:00","completed":"2024-03-11T21:30:07.3142230\u002B04:00","audio_url":"http://deleted_by_user","error":""},{"id":"ce522f10-d204-42e8-a838-6b95098145cc","resource_url":"https://api.assemblyai.com/v2/transcript/ce522f10-d204-42e8-a838-6b95098145cc","status":"error","created":"2024-03-11T21:23:59.9794200\u002B04:00","completed":"","audio_url":"https://storage.googleapis.com/client-docs-samples/nbc.mp3","error":"Download error, unable to download https://storage.googleapis.com/client-docs-samples/nbc.mp3. Please make sure the file exists and is accessible from the internet."},{"id":"28a73d01-98db-41dd-9e98-2533ba0af117","resource_url":"https://api.assemblyai.com/v2/transcript/28a73d01-98db-41dd-9e98-2533ba0af117","status":"completed","created":"2024-03-11T21:12:57.3722150\u002B04:00","completed":"2024-03-11T21:13:03.2670200\u002B04:00","audio_url":"https://storage.googleapis.com/aai-docs-samples/nbc.mp3","error":""}]}
    /// </summary>
    public sealed partial class TranscriptList
    {
        /// <summary>
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.<br/>
        /// Example: {"limit":10,"result_count":10,"current_url":"https://api.assemblyai.com/v2/transcript?limit=10","prev_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026before_id=62npeahu2b-a8ea-4112-854c-69542c20d90c","next_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026after_id=62nfw3mlar-01ad-4631-92f6-629929496eed"}
        /// </summary>
        /// <example>{"limit":10,"result_count":10,"current_url":"https://api.assemblyai.com/v2/transcript?limit=10","prev_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026before_id=62npeahu2b-a8ea-4112-854c-69542c20d90c","next_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026after_id=62nfw3mlar-01ad-4631-92f6-629929496eed"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageDetails PageDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptListItem> Transcripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptList" /> class.
        /// </summary>
        /// <param name="pageDetails">
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.<br/>
        /// Example: {"limit":10,"result_count":10,"current_url":"https://api.assemblyai.com/v2/transcript?limit=10","prev_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026before_id=62npeahu2b-a8ea-4112-854c-69542c20d90c","next_url":"https://api.assemblyai.com/v2/transcript?limit=10\u0026after_id=62nfw3mlar-01ad-4631-92f6-629929496eed"}
        /// </param>
        /// <param name="transcripts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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