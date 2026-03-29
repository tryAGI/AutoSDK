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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PatchTriggerInstancesManageByTriggerIdRequestStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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