//HintName: G.Models.IssuesListForAuthenticatedUserFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assigned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForAuthenticatedUserFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assigned")]
        Assigned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mentioned")]
        Mentioned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repos")]
        Repos,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subscribed")]
        Subscribed,
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
                IssuesListForAuthenticatedUserFilter.All => "all",
                IssuesListForAuthenticatedUserFilter.Assigned => "assigned",
                IssuesListForAuthenticatedUserFilter.Created => "created",
                IssuesListForAuthenticatedUserFilter.Mentioned => "mentioned",
                IssuesListForAuthenticatedUserFilter.Repos => "repos",
                IssuesListForAuthenticatedUserFilter.Subscribed => "subscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListForAuthenticatedUserFilter.All,
                "assigned" => IssuesListForAuthenticatedUserFilter.Assigned,
                "created" => IssuesListForAuthenticatedUserFilter.Created,
                "mentioned" => IssuesListForAuthenticatedUserFilter.Mentioned,
                "repos" => IssuesListForAuthenticatedUserFilter.Repos,
                "subscribed" => IssuesListForAuthenticatedUserFilter.Subscribed,
                _ => null,
            };
        }
    }
}