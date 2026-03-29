//HintName: G.Models.Squad.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Squad
    {
        /// <summary>
        /// This is the name of the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SquadMemberDTO> Members { get; set; }

        /// <summary>
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membersOverrides")]
        public global::G.AssistantOverrides? MembersOverrides { get; set; }

        /// <summary>
        /// This is the unique identifier for the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this squad belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the squad was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the squad was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad" /> class.
        /// </summary>
        /// <param name="members">
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the squad.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this squad belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the squad was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the squad was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the squad.
        /// </param>
        /// <param name="membersOverrides">
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Squad(
            global::System.Collections.Generic.IList<global::G.SquadMemberDTO> members,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            global::G.AssistantOverrides? membersOverrides)
        {
            this.Name = name;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.MembersOverrides = membersOverrides;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad" /> class.
        /// </summary>
        public Squad()
        {
        }
    }
}