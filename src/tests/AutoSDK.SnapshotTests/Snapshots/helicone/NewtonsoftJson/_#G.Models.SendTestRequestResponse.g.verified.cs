//HintName: G.Models.SendTestRequestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendTestRequestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public string? Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendTestRequestResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="response"></param>
        /// <param name="requestId"></param>
        /// <param name="error"></param>
        public SendTestRequestResponse(
            bool success,
            string? response,
            string? requestId,
            string? error)
        {
            this.Success = success;
            this.Response = response;
            this.RequestId = requestId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendTestRequestResponse" /> class.
        /// </summary>
        public SendTestRequestResponse()
        {
        }
    }
}