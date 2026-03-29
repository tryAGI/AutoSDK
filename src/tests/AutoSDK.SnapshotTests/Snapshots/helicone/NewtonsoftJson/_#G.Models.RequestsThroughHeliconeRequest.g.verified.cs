//HintName: G.Models.RequestsThroughHeliconeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestsThroughHeliconeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestsThroughHelicone", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequestsThroughHelicone { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsThroughHeliconeRequest" /> class.
        /// </summary>
        /// <param name="requestsThroughHelicone"></param>
        public RequestsThroughHeliconeRequest(
            bool requestsThroughHelicone)
        {
            this.RequestsThroughHelicone = requestsThroughHelicone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsThroughHeliconeRequest" /> class.
        /// </summary>
        public RequestsThroughHeliconeRequest()
        {
        }
    }
}