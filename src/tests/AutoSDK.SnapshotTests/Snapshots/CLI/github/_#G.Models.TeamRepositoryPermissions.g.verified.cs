//HintName: G.Models.TeamRepositoryPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamRepositoryPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Admin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triage")]
        public bool? Triage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Push { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintain")]
        public bool? Maintain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepositoryPermissions" /> class.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="pull"></param>
        /// <param name="triage"></param>
        /// <param name="push"></param>
        /// <param name="maintain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamRepositoryPermissions(
            bool admin,
            bool pull,
            bool push,
            bool? triage,
            bool? maintain)
        {
            this.Admin = admin;
            this.Pull = pull;
            this.Push = push;
            this.Triage = triage;
            this.Maintain = maintain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepositoryPermissions" /> class.
        /// </summary>
        public TeamRepositoryPermissions()
        {
        }
    }
}