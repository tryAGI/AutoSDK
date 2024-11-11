//HintName: G.Models.TeamPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamPermissions
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Triage { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Maintain { get; set; }

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
        /// Initializes a new instance of the <see cref="TeamPermissions" /> class.
        /// </summary>
        /// <param name="pull"></param>
        /// <param name="triage"></param>
        /// <param name="push"></param>
        /// <param name="maintain"></param>
        /// <param name="admin"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamPermissions(
            bool pull,
            bool triage,
            bool push,
            bool maintain,
            bool admin)
        {
            this.Pull = pull;
            this.Triage = triage;
            this.Push = push;
            this.Maintain = maintain;
            this.Admin = admin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamPermissions" /> class.
        /// </summary>
        public TeamPermissions()
        {
        }
    }
}