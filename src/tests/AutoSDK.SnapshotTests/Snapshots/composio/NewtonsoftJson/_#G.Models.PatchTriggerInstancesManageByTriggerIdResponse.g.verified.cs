//HintName: G.Models.PatchTriggerInstancesManageByTriggerIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTriggerInstancesManageByTriggerIdResponse
    {
        /// <summary>
        /// Status of the operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PatchTriggerInstancesManageByTriggerIdResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the operation
        /// </param>
        public PatchTriggerInstancesManageByTriggerIdResponse(
            global::G.PatchTriggerInstancesManageByTriggerIdResponseStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdResponse" /> class.
        /// </summary>
        public PatchTriggerInstancesManageByTriggerIdResponse()
        {
        }
    }
}