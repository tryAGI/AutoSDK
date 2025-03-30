//HintName: G.Models.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role to update the target principal with.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="editor")]
        Editor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="viewer")]
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole value)
        {
            return value switch
            {
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Admin => "admin",
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Editor => "editor",
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Admin,
                "editor" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Editor,
                "viewer" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Viewer,
                _ => null,
            };
        }
    }
}