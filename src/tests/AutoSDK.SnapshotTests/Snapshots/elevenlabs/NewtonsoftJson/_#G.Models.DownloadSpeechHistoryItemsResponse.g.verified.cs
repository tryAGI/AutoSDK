//HintName: G.Models.DownloadSpeechHistoryItemsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadSpeechHistoryItemsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadSpeechHistoryItemsResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        public DownloadSpeechHistoryItemsResponse(
            string? error,
            string? message)
        {
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadSpeechHistoryItemsResponse" /> class.
        /// </summary>
        public DownloadSpeechHistoryItemsResponse()
        {
        }
    }
}