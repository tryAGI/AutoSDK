//HintName: G.Models.IssuesListFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assigned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListFilter
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
    public static class IssuesListFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListFilter value)
        {
            return value switch
            {
                IssuesListFilter.Assigned => "assigned",
                IssuesListFilter.Created => "created",
                IssuesListFilter.Mentioned => "mentioned",
                IssuesListFilter.Subscribed => "subscribed",
                IssuesListFilter.Repos => "repos",
                IssuesListFilter.All => "all",
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
                "assigned" => IssuesListFilter.Assigned,
                "created" => IssuesListFilter.Created,
                "mentioned" => IssuesListFilter.Mentioned,
                "subscribed" => IssuesListFilter.Subscribed,
                "repos" => IssuesListFilter.Repos,
                "all" => IssuesListFilter.All,
                _ => null,
            };
        }
    }
}