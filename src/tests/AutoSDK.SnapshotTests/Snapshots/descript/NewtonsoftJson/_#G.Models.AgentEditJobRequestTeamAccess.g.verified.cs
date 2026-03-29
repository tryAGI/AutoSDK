//HintName: G.Models.AgentEditJobRequestTeamAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access level for team members when creating a new project.<br/>
    /// Only applicable when `project_name` is provided (not when using `project_id`).<br/>
    /// Defaults to `none` if not specified.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentEditJobRequestTeamAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comment")]
        Comment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="edit")]
        Edit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="view")]
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentEditJobRequestTeamAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentEditJobRequestTeamAccess value)
        {
            return value switch
            {
                AgentEditJobRequestTeamAccess.Comment => "comment",
                AgentEditJobRequestTeamAccess.Edit => "edit",
                AgentEditJobRequestTeamAccess.None => "none",
                AgentEditJobRequestTeamAccess.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentEditJobRequestTeamAccess? ToEnum(string value)
        {
            return value switch
            {
                "comment" => AgentEditJobRequestTeamAccess.Comment,
                "edit" => AgentEditJobRequestTeamAccess.Edit,
                "none" => AgentEditJobRequestTeamAccess.None,
                "view" => AgentEditJobRequestTeamAccess.View,
                _ => null,
            };
        }
    }
}