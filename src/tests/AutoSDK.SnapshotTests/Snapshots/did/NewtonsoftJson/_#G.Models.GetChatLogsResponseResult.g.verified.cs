//HintName: G.Models.GetChatLogsResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the export.
    /// </summary>
    public sealed partial class GetChatLogsResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResultUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatLogsResponseResult" /> class.
        /// </summary>
        /// <param name="resultUrl"></param>
        /// <param name="token"></param>
        public GetChatLogsResponseResult(
            string resultUrl,
            string? token)
        {
            this.Token = token;
            this.ResultUrl = resultUrl ?? throw new global::System.ArgumentNullException(nameof(resultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatLogsResponseResult" /> class.
        /// </summary>
        public GetChatLogsResponseResult()
        {
        }
    }
}