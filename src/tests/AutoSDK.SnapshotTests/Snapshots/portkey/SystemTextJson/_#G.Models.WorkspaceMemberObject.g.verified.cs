//HintName: G.Models.WorkspaceMemberObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: workspace-user
    /// </summary>
    public enum WorkspaceMemberObject
    {
        /// <summary>
        /// 
        /// </summary>
        WorkspaceUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceMemberObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceMemberObject value)
        {
            return value switch
            {
                WorkspaceMemberObject.WorkspaceUser => "workspace-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberObject? ToEnum(string value)
        {
            return value switch
            {
                "workspace-user" => WorkspaceMemberObject.WorkspaceUser,
                _ => null,
            };
        }
    }
}