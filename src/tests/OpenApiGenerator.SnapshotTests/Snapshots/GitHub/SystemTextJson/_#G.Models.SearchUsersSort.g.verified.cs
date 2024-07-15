//HintName: G.Models.SearchUsersSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchUsersSort
    {
        /// <summary>
        /// 
        /// </summary>
        Followers,
        /// <summary>
        /// 
        /// </summary>
        Repositories,
        /// <summary>
        /// 
        /// </summary>
        Joined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchUsersSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchUsersSort value)
        {
            return value switch
            {
                SearchUsersSort.Followers => "followers",
                SearchUsersSort.Repositories => "repositories",
                SearchUsersSort.Joined => "joined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchUsersSort? ToEnum(string value)
        {
            return value switch
            {
                "followers" => SearchUsersSort.Followers,
                "repositories" => SearchUsersSort.Repositories,
                "joined" => SearchUsersSort.Joined,
                _ => null,
            };
        }
    }
}