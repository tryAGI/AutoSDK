//HintName: G.Models.CallToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallToolResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallToolResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="output"></param>
        public CallToolResponse(
            string? id,
            string? output)
        {
            this.Id = id;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallToolResponse" /> class.
        /// </summary>
        public CallToolResponse()
        {
        }
    }
}