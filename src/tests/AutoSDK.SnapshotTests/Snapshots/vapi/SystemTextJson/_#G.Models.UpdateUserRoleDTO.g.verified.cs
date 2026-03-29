//HintName: G.Models.UpdateUserRoleDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserRoleDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateUserRoleDTORoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UpdateUserRoleDTORole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRoleDTO" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserRoleDTO(
            string userId,
            global::G.UpdateUserRoleDTORole role)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRoleDTO" /> class.
        /// </summary>
        public UpdateUserRoleDTO()
        {
        }
    }
}