//HintName: G.Models.SeatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Seat types for workspace members.<br/>
    /// Lite Member is equivalent to Basic Seat in the web application.<br/>
    /// Member is equivalent to Full Seat in the web application.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SeatType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_admin")]
        WorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_member")]
        WorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_lite_member")]
        WorkspaceLiteMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeatType value)
        {
            return value switch
            {
                SeatType.WorkspaceAdmin => "workspace_admin",
                SeatType.WorkspaceMember => "workspace_member",
                SeatType.WorkspaceLiteMember => "workspace_lite_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeatType? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => SeatType.WorkspaceAdmin,
                "workspace_member" => SeatType.WorkspaceMember,
                "workspace_lite_member" => SeatType.WorkspaceLiteMember,
                _ => null,
            };
        }
    }
}