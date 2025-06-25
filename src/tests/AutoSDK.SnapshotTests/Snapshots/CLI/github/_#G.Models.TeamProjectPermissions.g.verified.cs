//HintName: G.Models.TeamProjectPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamProjectPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Write { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Admin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProjectPermissions" /> class.
        /// </summary>
        /// <param name="read"></param>
        /// <param name="write"></param>
        /// <param name="admin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamProjectPermissions(
            bool read,
            bool write,
            bool admin)
        {
            this.Read = read;
            this.Write = write;
            this.Admin = admin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProjectPermissions" /> class.
        /// </summary>
        public TeamProjectPermissions()
        {
        }
    }
}