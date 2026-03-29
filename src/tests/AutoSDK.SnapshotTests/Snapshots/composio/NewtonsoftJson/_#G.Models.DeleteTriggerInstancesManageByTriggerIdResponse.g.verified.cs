//HintName: G.Models.DeleteTriggerInstancesManageByTriggerIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTriggerInstancesManageByTriggerIdResponse
    {
        /// <summary>
        /// The ID of the deleted trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TriggerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTriggerInstancesManageByTriggerIdResponse" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the deleted trigger instance
        /// </param>
        public DeleteTriggerInstancesManageByTriggerIdResponse(
            string triggerId)
        {
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTriggerInstancesManageByTriggerIdResponse" /> class.
        /// </summary>
        public DeleteTriggerInstancesManageByTriggerIdResponse()
        {
        }
    }
}