//HintName: G.Models.ProjectsListForUserState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsListForUserState
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
    public static class ProjectsListForUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListForUserState value)
        {
            return value switch
            {
                ProjectsListForUserState.All => "all",
                ProjectsListForUserState.Closed => "closed",
                ProjectsListForUserState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListForUserState? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListForUserState.All,
                "closed" => ProjectsListForUserState.Closed,
                "open" => ProjectsListForUserState.Open,
                _ => null,
            };
        }
    }
}