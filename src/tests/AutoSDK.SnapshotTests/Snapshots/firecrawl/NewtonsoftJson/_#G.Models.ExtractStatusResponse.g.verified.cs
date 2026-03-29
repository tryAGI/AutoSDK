//HintName: G.Models.ExtractStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The current status of the extract job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ExtractStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractStatusResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
        /// <param name="status">
        /// The current status of the extract job
        /// </param>
        /// <param name="expiresAt"></param>
        public ExtractStatusResponse(
            bool? success,
            object? data,
            global::G.ExtractStatusResponseStatus? status,
            global::System.DateTime? expiresAt)
        {
            this.Success = success;
            this.Data = data;
            this.Status = status;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractStatusResponse" /> class.
        /// </summary>
        public ExtractStatusResponse()
        {
        }
    }
}