//HintName: G.Models.IssuesListForOrgFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assigned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForOrgFilter
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="subscribed")]
        Subscribed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repos")]
        Repos,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
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
                IssuesListForOrgFilter.Assigned => "assigned",
                IssuesListForOrgFilter.Created => "created",
                IssuesListForOrgFilter.Mentioned => "mentioned",
                IssuesListForOrgFilter.Subscribed => "subscribed",
                IssuesListForOrgFilter.Repos => "repos",
                IssuesListForOrgFilter.All => "all",
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
                "assigned" => IssuesListForOrgFilter.Assigned,
                "created" => IssuesListForOrgFilter.Created,
                "mentioned" => IssuesListForOrgFilter.Mentioned,
                "subscribed" => IssuesListForOrgFilter.Subscribed,
                "repos" => IssuesListForOrgFilter.Repos,
                "all" => IssuesListForOrgFilter.All,
                _ => null,
            };
        }
    }
}