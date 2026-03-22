//HintName: G.Models.ProjectsListForRepoState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsListForRepoState
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsListForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListForRepoState value)
        {
            return value switch
            {
                ProjectsListForRepoState.All => "all",
                ProjectsListForRepoState.Closed => "closed",
                ProjectsListForRepoState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListForRepoState? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListForRepoState.All,
                "closed" => ProjectsListForRepoState.Closed,
                "open" => ProjectsListForRepoState.Open,
                _ => null,
            };
        }
    }
}