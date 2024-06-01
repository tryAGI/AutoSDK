//HintName: G.Models.IssuesListForAuthenticatedUserFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: assigned
    /// </summary>
    public enum IssuesListForAuthenticatedUserFilter
    {
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
        Subscribed,
        /// <summary>
        /// 
        /// </summary>
        Repos,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForAuthenticatedUserFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForAuthenticatedUserFilter value)
        {
            return value switch
            {
                IssuesListForAuthenticatedUserFilter.Assigned => "assigned",
                IssuesListForAuthenticatedUserFilter.Created => "created",
                IssuesListForAuthenticatedUserFilter.Mentioned => "mentioned",
                IssuesListForAuthenticatedUserFilter.Subscribed => "subscribed",
                IssuesListForAuthenticatedUserFilter.Repos => "repos",
                IssuesListForAuthenticatedUserFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserFilter ToEnum(string value)
        {
            return value switch
            {
                "assigned" => IssuesListForAuthenticatedUserFilter.Assigned,
                "created" => IssuesListForAuthenticatedUserFilter.Created,
                "mentioned" => IssuesListForAuthenticatedUserFilter.Mentioned,
                "subscribed" => IssuesListForAuthenticatedUserFilter.Subscribed,
                "repos" => IssuesListForAuthenticatedUserFilter.Repos,
                "all" => IssuesListForAuthenticatedUserFilter.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}