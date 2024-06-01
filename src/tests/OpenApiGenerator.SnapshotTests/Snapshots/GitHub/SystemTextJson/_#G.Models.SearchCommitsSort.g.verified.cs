//HintName: G.Models.SearchCommitsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchCommitsSort
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorDate,
        /// <summary>
        /// 
        /// </summary>
        CommitterDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommitsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommitsSort value)
        {
            return value switch
            {
                SearchCommitsSort.AuthorDate => "author-date",
                SearchCommitsSort.CommitterDate => "committer-date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommitsSort ToEnum(string value)
        {
            return value switch
            {
                "author-date" => SearchCommitsSort.AuthorDate,
                "committer-date" => SearchCommitsSort.CommitterDate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}