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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Prebuilt URL with your transcription `id` to fetch the result<br/>
        /// Example: https://api.gladia.io/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("result_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResultUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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