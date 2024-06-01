//HintName: G.Models.SearchReposSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchReposSort
    {
        /// <summary>
        /// 
        /// </summary>
        Stars,
        /// <summary>
        /// 
        /// </summary>
        Forks,
        /// <summary>
        /// 
        /// </summary>
        HelpWantedIssues,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchReposSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchReposSort value)
        {
            return value switch
            {
                SearchReposSort.Stars => "stars",
                SearchReposSort.Forks => "forks",
                SearchReposSort.HelpWantedIssues => "help-wanted-issues",
                SearchReposSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchReposSort ToEnum(string value)
        {
            return value switch
            {
                "stars" => SearchReposSort.Stars,
                "forks" => SearchReposSort.Forks,
                "help-wanted-issues" => SearchReposSort.HelpWantedIssues,
                "updated" => SearchReposSort.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}