//HintName: G.Models.WorkspaceMemberListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: list
    /// </summary>
    public enum WorkspaceMemberListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceMemberListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceMemberListObject value)
        {
            return value switch
            {
                WorkspaceMemberListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => WorkspaceMemberListObject.List,
                _ => null,
            };
        }
    }
}