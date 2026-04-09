//HintName: G.Models.PatchOrganizationMembersOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationMembersOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter))]
        public global::G.PatchOrganizationMembersOutputStatus Status { get; set; }

        /// <summary>
        /// The id of the org that was modified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// If invite emails failed to send for some reason, the patch operation will still complete, but we will return an error message here
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_email_error")]
        public string? SendEmailError { get; set; }

        /// <summary>
        /// If service accounts with tokens were created, this will contain the added users with their API keys
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_users")]
        public global::System.Collections.Generic.IList<global::G.PatchOrganizationMembersOutputAddedUser>? AddedUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersOutput" /> class.
        /// </summary>
        /// <param name="orgId">
        /// The id of the org that was modified.
        /// </param>
        /// <param name="status"></param>
        /// <param name="sendEmailError">
        /// If invite emails failed to send for some reason, the patch operation will still complete, but we will return an error message here
        /// </param>
        /// <param name="addedUsers">
        /// If service accounts with tokens were created, this will contain the added users with their API keys
        /// </param>
        public PatchOrganizationMembersOutput(
            string orgId,
            global::G.PatchOrganizationMembersOutputStatus status,
            string? sendEmailError,
            global::System.Collections.Generic.IList<global::G.PatchOrganizationMembersOutputAddedUser>? addedUsers)
        {
            this.Status = status;
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.SendEmailError = sendEmailError;
            this.AddedUsers = addedUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersOutput" /> class.
        /// </summary>
        public PatchOrganizationMembersOutput()
        {
        }
    }
}