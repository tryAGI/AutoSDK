//HintName: G.Models.ProjectsListCardsArchivedState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: not_archived
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsListCardsArchivedState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archived")]
        Archived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_archived")]
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
        public static ProjectsListCardsArchivedState ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsListCardsArchivedState.All,
                "archived" => ProjectsListCardsArchivedState.Archived,
                "not_archived" => ProjectsListCardsArchivedState.NotArchived,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}