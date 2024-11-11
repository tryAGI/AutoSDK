//HintName: G.Models.OrgMembershipPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgMembershipPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_create_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCreateRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembershipPermissions" /> class.
        /// </summary>
        /// <param name="canCreateRepository"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgMembershipPermissions(
            bool canCreateRepository)
        {
            this.CanCreateRepository = canCreateRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembershipPermissions" /> class.
        /// </summary>
        public OrgMembershipPermissions()
        {
        }
    }
}