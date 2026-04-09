//HintName: G.Models.PatchTriggerInstancesManageByTriggerIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTriggerInstancesManageByTriggerIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusJsonConverter))]
        public global::G.PatchTriggerInstancesManageByTriggerIdRequestStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        public PatchTriggerInstancesManageByTriggerIdRequest(
            global::G.PatchTriggerInstancesManageByTriggerIdRequestStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdRequest" /> class.
        /// </summary>
        public PatchTriggerInstancesManageByTriggerIdRequest()
        {
        }
    }
}