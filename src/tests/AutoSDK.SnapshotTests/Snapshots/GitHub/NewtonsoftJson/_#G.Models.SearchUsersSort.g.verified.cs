﻿//HintName: G.Models.SearchUsersSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchUsersSort
    {
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="followers")]
        Followers,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repositories")]
        Repositories,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="joined")]
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