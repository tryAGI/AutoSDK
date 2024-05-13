//HintName: G.Models.BatchRequestOutputResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRequestOutputResponse
    {
        /// <summary>
        /// The HTTP status code of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// An unique identifier for the OpenAI API request. Please include this request ID when contacting support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The JSON body of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public BatchRequestOutputResponseBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}