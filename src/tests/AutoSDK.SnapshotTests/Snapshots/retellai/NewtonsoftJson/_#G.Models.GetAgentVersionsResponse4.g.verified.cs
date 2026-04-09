//HintName: G.Models.GetAgentVersionsResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentVersionsResponse4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetAgentVersionsResponseStatus4JsonConverter))]
        public global::G.GetAgentVersionsResponseStatus4? Status { get; set; }

        /// <summary>
        /// Example: An unexpected server error occurred.
        /// </summary>
        /// <example>An unexpected server error occurred.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentVersionsResponse4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: An unexpected server error occurred.
        /// </param>
        public GetAgentVersionsResponse4(
            global::G.GetAgentVersionsResponseStatus4? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentVersionsResponse4" /> class.
        /// </summary>
        public GetAgentVersionsResponse4()
        {
        }
    }
}