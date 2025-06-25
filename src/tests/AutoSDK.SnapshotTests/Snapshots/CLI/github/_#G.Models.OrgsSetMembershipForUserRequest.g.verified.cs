﻿//HintName: G.Models.OrgsSetMembershipForUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsSetMembershipForUserRequest
    {
        /// <summary>
        /// The role to give the user in the organization. Can be one of:  <br/>
        ///  * `admin` - The user will become an owner of the organization.  <br/>
        ///  * `member` - The user will become a non-owner member of the organization.<br/>
        /// Default Value: member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsSetMembershipForUserRequestRoleJsonConverter))]
        public global::G.OrgsSetMembershipForUserRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetMembershipForUserRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The role to give the user in the organization. Can be one of:  <br/>
        ///  * `admin` - The user will become an owner of the organization.  <br/>
        ///  * `member` - The user will become a non-owner member of the organization.<br/>
        /// Default Value: member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetMembershipForUserRequest(
            global::G.OrgsSetMembershipForUserRequestRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetMembershipForUserRequest" /> class.
        /// </summary>
        public OrgsSetMembershipForUserRequest()
        {
        }
    }
}