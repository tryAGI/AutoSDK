//HintName: G.Models.GetLLMsTxtStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLLMsTxtStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetLLMsTxtStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.GetLLMsTxtStatusResponseData? Data { get; set; }

        /// <summary>
        /// When the generated content will expire
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLLMsTxtStatusResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <param name="expiresAt">
        /// When the generated content will expire
        /// </param>
        public GetLLMsTxtStatusResponse(
            bool? success,
            global::G.GetLLMsTxtStatusResponseStatus? status,
            global::G.GetLLMsTxtStatusResponseData? data,
            global::System.DateTime? expiresAt)
        {
            this.Success = success;
            this.Status = status;
            this.Data = data;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLLMsTxtStatusResponse" /> class.
        /// </summary>
        public GetLLMsTxtStatusResponse()
        {
        }
    }
}