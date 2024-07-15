//HintName: G.Models.TeamsAddOrUpdateMembershipForUserLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateMembershipForUserLegacyRequest
    {
        /// <summary>
        /// The role that this user should have in the team.<br/>
        /// Default Value: member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.TeamsAddOrUpdateMembershipForUserLegacyRequestRoleJsonConverter))]
        public global::G.TeamsAddOrUpdateMembershipForUserLegacyRequestRole? Role { get; set; } = global::G.TeamsAddOrUpdateMembershipForUserLegacyRequestRole.Member;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}