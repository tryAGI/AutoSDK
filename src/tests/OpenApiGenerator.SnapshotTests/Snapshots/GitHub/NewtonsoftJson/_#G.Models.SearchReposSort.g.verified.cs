//HintName: G.Models.SearchReposSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchReposSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stars")]
        Stars,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forks")]
        Forks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="help-wanted-issues")]
        HelpWantedIssues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
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