//HintName: G.Models.GetProjectsResponseItemMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseItemMember
    {
        /// <summary>
        /// Username of the project member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Role of the member in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseItemMember" /> class.
        /// </summary>
        /// <param name="username">
        /// Username of the project member
        /// </param>
        /// <param name="role">
        /// Role of the member in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseItemMember(
            string? username,
            string? role)
        {
            this.Username = username;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseItemMember" /> class.
        /// </summary>
        public GetProjectsResponseItemMember()
        {
        }
    }
}