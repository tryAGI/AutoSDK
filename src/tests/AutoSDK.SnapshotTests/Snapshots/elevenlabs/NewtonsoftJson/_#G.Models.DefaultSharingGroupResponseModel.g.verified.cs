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
        [global::Newtonsoft.Json.JsonProperty("group", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkspaceGroupResponseModel Group { get; set; } = default!;

        /// <summary>
        /// The permission level to grant to the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DefaultSharingGroupResponseModelPermissionLevel PermissionLevel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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