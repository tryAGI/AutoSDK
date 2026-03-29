//HintName: G.Models.ImportProjectMediaRequestTeamAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access level for drive members. Only applicable when creating a new project<br/>
    /// (when project_id is not provided). Defaults to `none` if not specified.<br/>
    /// - edit: Users can edit the project<br/>
    /// - comment: Users can view and comment but not edit<br/>
    /// - view: Users can view but not comment or edit<br/>
    /// - none: No shared access (private to owner)<br/>
    /// Default Value: none<br/>
    /// Example: edit
    /// </summary>
    public enum ImportProjectMediaRequestTeamAccess
    {
        /// <summary>
        /// Users can view and comment but not edit
        /// </summary>
        Comment,
        /// <summary>
        /// Users can edit the project
        /// </summary>
        Edit,
        /// <summary>
        /// No shared access (private to owner)
        /// </summary>
        None,
        /// <summary>
        /// Users can view and comment but not edit
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportProjectMediaRequestTeamAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportProjectMediaRequestTeamAccess value)
        {
            return value switch
            {
                ImportProjectMediaRequestTeamAccess.Comment => "comment",
                ImportProjectMediaRequestTeamAccess.Edit => "edit",
                ImportProjectMediaRequestTeamAccess.None => "none",
                ImportProjectMediaRequestTeamAccess.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportProjectMediaRequestTeamAccess? ToEnum(string value)
        {
            return value switch
            {
                "comment" => ImportProjectMediaRequestTeamAccess.Comment,
                "edit" => ImportProjectMediaRequestTeamAccess.Edit,
                "none" => ImportProjectMediaRequestTeamAccess.None,
                "view" => ImportProjectMediaRequestTeamAccess.View,
                _ => null,
            };
        }
    }
}