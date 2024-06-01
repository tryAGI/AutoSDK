//HintName: G.Models.ReposListForksSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: newest
    /// </summary>
    public enum ReposListForksSort
    {
        /// <summary>
        /// 
        /// </summary>
        Newest,
        /// <summary>
        /// 
        /// </summary>
        Oldest,
        /// <summary>
        /// 
        /// </summary>
        Stargazers,
        /// <summary>
        /// 
        /// </summary>
        Watchers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForksSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForksSort value)
        {
            return value switch
            {
                ReposListForksSort.Newest => "newest",
                ReposListForksSort.Oldest => "oldest",
                ReposListForksSort.Stargazers => "stargazers",
                ReposListForksSort.Watchers => "watchers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForksSort ToEnum(string value)
        {
            return value switch
            {
                "newest" => ReposListForksSort.Newest,
                "oldest" => ReposListForksSort.Oldest,
                "stargazers" => ReposListForksSort.Stargazers,
                "watchers" => ReposListForksSort.Watchers,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}