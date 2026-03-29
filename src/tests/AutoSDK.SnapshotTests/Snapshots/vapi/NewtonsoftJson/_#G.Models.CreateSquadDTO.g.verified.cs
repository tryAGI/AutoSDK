//HintName: G.Models.CreateSquadDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSquadDTO
    {
        /// <summary>
        /// This is the name of the squad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SquadMemberDTO> Members { get; set; } = default!;

        /// <summary>
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membersOverrides")]
        public global::G.AssistantOverrides? MembersOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSquadDTO" /> class.
        /// </summary>
        /// <param name="members">
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </param>
        /// <param name="name">
        /// This is the name of the squad.
        /// </param>
        /// <param name="membersOverrides">
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </param>
        public CreateSquadDTO(
            global::System.Collections.Generic.IList<global::G.SquadMemberDTO> members,
            string? name,
            global::G.AssistantOverrides? membersOverrides)
        {
            this.Name = name;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.MembersOverrides = membersOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSquadDTO" /> class.
        /// </summary>
        public CreateSquadDTO()
        {
        }
    }
}