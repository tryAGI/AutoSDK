//HintName: G.Models.RoleUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleUser
    {
        /// <summary>
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The name of the target role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUser" /> class.
        /// </summary>
        /// <param name="userName">
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </param>
        /// <param name="roleName">
        /// The name of the target role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleUser(
            string userName,
            string roleName)
        {
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUser" /> class.
        /// </summary>
        public RoleUser()
        {
        }
    }
}