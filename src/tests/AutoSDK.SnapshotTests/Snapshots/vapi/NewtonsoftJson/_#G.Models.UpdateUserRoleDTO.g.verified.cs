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
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateUserRoleDTORoleJsonConverter))]
        public global::G.UpdateUserRoleDTORole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRoleDTO" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role"></param>
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