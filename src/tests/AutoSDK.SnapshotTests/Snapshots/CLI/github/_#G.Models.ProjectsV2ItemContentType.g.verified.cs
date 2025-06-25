//HintName: G.Models.ProjectsV2ItemContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content tracked in a project item
    /// </summary>
    public enum ProjectsV2ItemContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Issue,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        DraftIssue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2ItemContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2ItemContentType value)
        {
            return value switch
            {
                ProjectsV2ItemContentType.Issue => "Issue",
                ProjectsV2ItemContentType.PullRequest => "PullRequest",
                ProjectsV2ItemContentType.DraftIssue => "DraftIssue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2ItemContentType? ToEnum(string value)
        {
            return value switch
            {
                "Issue" => ProjectsV2ItemContentType.Issue,
                "PullRequest" => ProjectsV2ItemContentType.PullRequest,
                "DraftIssue" => ProjectsV2ItemContentType.DraftIssue,
                _ => null,
            };
        }
    }
}