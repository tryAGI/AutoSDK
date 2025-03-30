//HintName: G.Models.OrganizationUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update organization schema.
    /// </summary>
    public sealed partial class OrganizationUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unshare_all")]
        public bool? UnshareAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="publicSharingDisabled"></param>
        /// <param name="unshareAll"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUpdate(
            string? displayName,
            bool? publicSharingDisabled,
            bool? unshareAll)
        {
            this.DisplayName = displayName;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.UnshareAll = unshareAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        public OrganizationUpdate()
        {
        }
    }
}