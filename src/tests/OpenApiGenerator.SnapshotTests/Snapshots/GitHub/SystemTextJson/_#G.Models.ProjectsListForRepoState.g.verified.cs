//HintName: G.Models.ProjectsListForRepoState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: open
    /// </summary>
    public enum ProjectsListForRepoState
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
    public static class ProjectsListForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListForRepoState value)
        {
            return value switch
            {
                ProjectsListForRepoState.Open => "open",
                ProjectsListForRepoState.Closed => "closed",
                ProjectsListForRepoState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListForRepoState ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsListForRepoState.Open,
                "closed" => ProjectsListForRepoState.Closed,
                "all" => ProjectsListForRepoState.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}