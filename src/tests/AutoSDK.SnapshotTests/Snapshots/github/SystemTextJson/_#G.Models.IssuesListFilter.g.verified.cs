//HintName: G.Models.IssuesListFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assigned
    /// </summary>
    public enum IssuesListFilter
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Assigned,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Mentioned,
        /// <summary>
        /// 
        /// </summary>
        Repos,
        /// <summary>
        /// 
        /// </summary>
        Subscribed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListFilter value)
        {
            return value switch
            {
                IssuesListFilter.All => "all",
                IssuesListFilter.Assigned => "assigned",
                IssuesListFilter.Created => "created",
                IssuesListFilter.Mentioned => "mentioned",
                IssuesListFilter.Repos => "repos",
                IssuesListFilter.Subscribed => "subscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListFilter.All,
                "assigned" => IssuesListFilter.Assigned,
                "created" => IssuesListFilter.Created,
                "mentioned" => IssuesListFilter.Mentioned,
                "repos" => IssuesListFilter.Repos,
                "subscribed" => IssuesListFilter.Subscribed,
                _ => null,
            };
        }
    }
}