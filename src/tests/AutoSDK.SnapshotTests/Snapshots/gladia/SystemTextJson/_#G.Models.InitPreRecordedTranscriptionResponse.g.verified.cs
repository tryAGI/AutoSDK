//HintName: G.Models.InitPreRecordedTranscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitPreRecordedTranscriptionResponse
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Prebuilt URL with your transcription `id` to fetch the result<br/>
        /// Example: https://api.gladia.io/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitPreRecordedTranscriptionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="resultUrl">
        /// Prebuilt URL with your transcription `id` to fetch the result<br/>
        /// Example: https://api.gladia.io/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitPreRecordedTranscriptionResponse(
            global::System.Guid id,
            string resultUrl)
        {
            this.Id = id;
            this.ResultUrl = resultUrl ?? throw new global::System.ArgumentNullException(nameof(resultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitPreRecordedTranscriptionResponse" /> class.
        /// </summary>
        public InitPreRecordedTranscriptionResponse()
        {
        }
    }
}