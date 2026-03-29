//HintName: G.Models.WorkspaceMemberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: active
    /// </summary>
    public enum WorkspaceMemberStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceMemberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceMemberStatus value)
        {
            return value switch
            {
                WorkspaceMemberStatus.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => WorkspaceMemberStatus.Active,
                _ => null,
            };
        }
    }
}