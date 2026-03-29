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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetLLMsTxtStatusResponseStatusJsonConverter))]
        public global::G.GetLLMsTxtStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.GetLLMsTxtStatusResponseData? Data { get; set; }

        /// <summary>
        /// When the generated content will expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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