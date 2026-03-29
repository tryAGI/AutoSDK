//HintName: G.Models.GetStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStatusResponse
    {
        /// <summary>
        /// API status indicator<br/>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetStatusResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// API status indicator<br/>
        /// Example: ok
        /// </param>
        public GetStatusResponse(
            global::G.GetStatusResponseStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        public GetStatusResponse()
        {
        }
    }
}