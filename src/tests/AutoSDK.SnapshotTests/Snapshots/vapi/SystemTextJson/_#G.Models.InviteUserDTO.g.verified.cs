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
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteUserDTORoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InviteUserDTORole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectTo")]
        public string? RedirectTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserDTO" /> class.
        /// </summary>
        /// <param name="emails"></param>
        /// <param name="role"></param>
        /// <param name="redirectTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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