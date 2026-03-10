//HintName: G.Models.DefaultSharingGroupResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DefaultSharingGroupResponseModel
    {
        /// <summary>
        /// The group to share with by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkspaceGroupResponseModel Group { get; set; }

        /// <summary>
        /// The permission level to grant to the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DefaultSharingGroupResponseModelPermissionLevel PermissionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingGroupResponseModel" /> class.
        /// </summary>
        /// <param name="group">
        /// The group to share with by default
        /// </param>
        /// <param name="permissionLevel">
        /// The permission level to grant to the group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultSharingGroupResponseModel(
            global::G.WorkspaceGroupResponseModel group,
            global::G.DefaultSharingGroupResponseModelPermissionLevel permissionLevel)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.PermissionLevel = permissionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingGroupResponseModel" /> class.
        /// </summary>
        public DefaultSharingGroupResponseModel()
        {
        }
    }
}