//HintName: G.Models.BulkAssignMembersToGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkAssignMembersToGuardrailRequest
    {
        /// <summary>
        /// Array of member user IDs to assign to the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_user_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> MemberUserIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignMembersToGuardrailRequest" /> class.
        /// </summary>
        /// <param name="memberUserIds">
        /// Array of member user IDs to assign to the guardrail
        /// </param>
        public BulkAssignMembersToGuardrailRequest(
            global::System.Collections.Generic.IList<string> memberUserIds)
        {
            this.MemberUserIds = memberUserIds ?? throw new global::System.ArgumentNullException(nameof(memberUserIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignMembersToGuardrailRequest" /> class.
        /// </summary>
        public BulkAssignMembersToGuardrailRequest()
        {
        }
    }
}