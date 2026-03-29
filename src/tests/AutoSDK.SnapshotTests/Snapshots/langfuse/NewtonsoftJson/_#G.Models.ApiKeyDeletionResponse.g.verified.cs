//HintName: G.Models.ApiKeyDeletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for API key deletion
    /// </summary>
    public sealed partial class ApiKeyDeletionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDeletionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        public ApiKeyDeletionResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDeletionResponse" /> class.
        /// </summary>
        public ApiKeyDeletionResponse()
        {
        }
    }
}