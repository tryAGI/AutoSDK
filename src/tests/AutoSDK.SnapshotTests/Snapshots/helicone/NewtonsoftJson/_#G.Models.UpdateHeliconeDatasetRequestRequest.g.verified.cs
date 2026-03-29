//HintName: G.Models.UpdateHeliconeDatasetRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateHeliconeDatasetRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseBody")]
        public global::G.Json? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestBody")]
        public global::G.Json? RequestBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHeliconeDatasetRequestRequest" /> class.
        /// </summary>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
        public UpdateHeliconeDatasetRequestRequest(
            global::G.Json? responseBody,
            global::G.Json? requestBody)
        {
            this.ResponseBody = responseBody;
            this.RequestBody = requestBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHeliconeDatasetRequestRequest" /> class.
        /// </summary>
        public UpdateHeliconeDatasetRequestRequest()
        {
        }
    }
}