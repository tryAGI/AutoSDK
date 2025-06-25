﻿//HintName: G.Models.TeamsAddOrUpdateMembershipForUserInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateMembershipForUserInOrgRequest
    {
        /// <summary>
        /// The role that this user should have in the team.<br/>
        /// Default Value: member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamsAddOrUpdateMembershipForUserInOrgRequestRoleJsonConverter))]
        public global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateMembershipForUserInOrgRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The role that this user should have in the team.<br/>
        /// Default Value: member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsAddOrUpdateMembershipForUserInOrgRequest(
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateMembershipForUserInOrgRequest" /> class.
        /// </summary>
        public TeamsAddOrUpdateMembershipForUserInOrgRequest()
        {
        }
    }
}