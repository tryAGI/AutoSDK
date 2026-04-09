//HintName: G.Models.InviteUserDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteUserDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Emails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InviteUserDTORoleJsonConverter))]
        public global::G.InviteUserDTORole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirectTo")]
        public string? RedirectTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserDTO" /> class.
        /// </summary>
        /// <param name="emails"></param>
        /// <param name="role"></param>
        /// <param name="redirectTo"></param>
        public InviteUserDTO(
            global::System.Collections.Generic.IList<string> emails,
            global::G.InviteUserDTORole role,
            string? redirectTo)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Role = role;
            this.RedirectTo = redirectTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserDTO" /> class.
        /// </summary>
        public InviteUserDTO()
        {
        }
    }
}