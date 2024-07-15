//HintName: G.Models.ProjectsListForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsListForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        All,
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
                ProjectsListForOrgState.Open => "open",
                ProjectsListForOrgState.Closed => "closed",
                ProjectsListForOrgState.All => "all",
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
                "open" => ProjectsListForOrgState.Open,
                "closed" => ProjectsListForOrgState.Closed,
                "all" => ProjectsListForOrgState.All,
                _ => null,
            };
        }
    }
}