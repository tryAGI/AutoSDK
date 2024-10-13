//HintName: G.Models.OrgsCreateInvitationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateInvitationRequest
    {
        /// <summary>
        /// **Required unless you provide `email`**. GitHub user ID for the person you are inviting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitee_id")]
        public int? InviteeId { get; set; }

        /// <summary>
        /// **Required unless you provide `invitee_id`**. Email address of the person you are inviting, which can be an existing GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The role for the new member. <br/>
        ///  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.  <br/>
        ///  * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.  <br/>
        ///  * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization. <br/>
        ///  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.<br/>
        /// Default Value: direct_member
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.OrgsCreateInvitationRequestRole? Role { get; set; } = global::G.OrgsCreateInvitationRequestRole.DirectMember;

        /// <summary>
        /// Specify IDs for the teams you want to invite new members to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_ids")]
        public global::System.Collections.Generic.IList<int>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrgsCreateInvitationRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrgsCreateInvitationRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}