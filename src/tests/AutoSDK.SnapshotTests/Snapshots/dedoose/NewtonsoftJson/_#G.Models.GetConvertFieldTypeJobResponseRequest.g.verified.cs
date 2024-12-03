//HintName: G.Models.GetConvertFieldTypeJobResponseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConvertFieldTypeJobResponseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid JobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvertFieldTypeJobResponseRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        public GetConvertFieldTypeJobResponseRequest(
            global::System.Guid jobId)
        {
            this.JobId = jobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvertFieldTypeJobResponseRequest" /> class.
        /// </summary>
        public GetConvertFieldTypeJobResponseRequest()
        {
        }
    }
}