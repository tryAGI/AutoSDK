//HintName: G.Models.UserInviteParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User invite parameters
    /// </summary>
    public sealed partial class UserInviteParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInviteParam" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInviteParam(
            string? email,
            string? name)
        {
            this.Email = email;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInviteParam" /> class.
        /// </summary>
        public UserInviteParam()
        {
        }
    }
}