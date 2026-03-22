//HintName: G.Models.IssuesListForOrgFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assigned
    /// </summary>
    public enum IssuesListForOrgFilter
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
    public static class IssuesListForOrgFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForOrgFilter value)
        {
            return value switch
            {
                IssuesListForOrgFilter.All => "all",
                IssuesListForOrgFilter.Assigned => "assigned",
                IssuesListForOrgFilter.Created => "created",
                IssuesListForOrgFilter.Mentioned => "mentioned",
                IssuesListForOrgFilter.Repos => "repos",
                IssuesListForOrgFilter.Subscribed => "subscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForOrgFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListForOrgFilter.All,
                "assigned" => IssuesListForOrgFilter.Assigned,
                "created" => IssuesListForOrgFilter.Created,
                "mentioned" => IssuesListForOrgFilter.Mentioned,
                "repos" => IssuesListForOrgFilter.Repos,
                "subscribed" => IssuesListForOrgFilter.Subscribed,
                _ => null,
            };
        }
    }
}