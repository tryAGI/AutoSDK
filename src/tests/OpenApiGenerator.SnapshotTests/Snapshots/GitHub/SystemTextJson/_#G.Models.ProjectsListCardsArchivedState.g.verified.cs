//HintName: G.Models.ProjectsListCardsArchivedState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: not_archived
    /// </summary>
    public enum ProjectsListCardsArchivedState
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        NotArchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsListCardsArchivedStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListCardsArchivedState value)
        {
            return value switch
            {
                ProjectsListCardsArchivedState.All => "all",
                ProjectsListCardsArchivedState.Archived => "archived",
                ProjectsListCardsArchivedState.NotArchived => "not_archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListCardsArchivedState? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListCardsArchivedState.All,
                "archived" => ProjectsListCardsArchivedState.Archived,
                "not_archived" => ProjectsListCardsArchivedState.NotArchived,
                _ => null,
            };
        }
    }
}