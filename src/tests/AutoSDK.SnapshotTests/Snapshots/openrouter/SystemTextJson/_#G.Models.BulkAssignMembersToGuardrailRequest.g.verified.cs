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
        [global::System.Text.Json.Serialization.JsonPropertyName("member_user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MemberUserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignMembersToGuardrailRequest" /> class.
        /// </summary>
        /// <param name="memberUserIds">
        /// Array of member user IDs to assign to the guardrail
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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