//HintName: G.Models.WorkspaceWithUsersDefaultsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceWithUsersDefaultsObject
    {
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceWithUsersDefaultsObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceWithUsersDefaultsObject value)
        {
            return value switch
            {
                WorkspaceWithUsersDefaultsObject.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceWithUsersDefaultsObject? ToEnum(string value)
        {
            return value switch
            {
                "workspace" => WorkspaceWithUsersDefaultsObject.Workspace,
                _ => null,
            };
        }
    }
}