//HintName: G.Models.CollaboratorPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollaboratorPermissions
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
        /// Initializes a new instance of the <see cref="CollaboratorPermissions" /> class.
        /// </summary>
        /// <param name="pull"></param>
        /// <param name="triage"></param>
        /// <param name="push"></param>
        /// <param name="maintain"></param>
        /// <param name="admin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollaboratorPermissions(
            bool pull,
            bool push,
            bool admin,
            bool? triage,
            bool? maintain)
        {
            this.Pull = pull;
            this.Push = push;
            this.Admin = admin;
            this.Triage = triage;
            this.Maintain = maintain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorPermissions" /> class.
        /// </summary>
        public CollaboratorPermissions()
        {
        }
    }
}