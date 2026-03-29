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
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTriggerInstancesManageByTriggerIdResponse" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the deleted trigger instance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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