//HintName: G.Models.IssuesListForAuthenticatedUserState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForAuthenticatedUserState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForAuthenticatedUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForAuthenticatedUserState value)
        {
            return value switch
            {
                IssuesListForAuthenticatedUserState.All => "all",
                IssuesListForAuthenticatedUserState.Closed => "closed",
                IssuesListForAuthenticatedUserState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserState? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListForAuthenticatedUserState.All,
                "closed" => IssuesListForAuthenticatedUserState.Closed,
                "open" => IssuesListForAuthenticatedUserState.Open,
                _ => null,
            };
        }
    }
}