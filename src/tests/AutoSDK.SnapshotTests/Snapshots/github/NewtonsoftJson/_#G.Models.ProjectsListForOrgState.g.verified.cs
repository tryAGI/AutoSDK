//HintName: G.Models.ProjectsListForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsListForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsListForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListForOrgState value)
        {
            return value switch
            {
                ProjectsListForOrgState.All => "all",
                ProjectsListForOrgState.Closed => "closed",
                ProjectsListForOrgState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListForOrgState? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListForOrgState.All,
                "closed" => ProjectsListForOrgState.Closed,
                "open" => ProjectsListForOrgState.Open,
                _ => null,
            };
        }
    }
}