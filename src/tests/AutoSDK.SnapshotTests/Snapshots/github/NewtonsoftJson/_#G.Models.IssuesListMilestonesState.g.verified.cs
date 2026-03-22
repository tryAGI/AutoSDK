//HintName: G.Models.IssuesListMilestonesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListMilestonesState
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
    public static class IssuesListMilestonesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListMilestonesState value)
        {
            return value switch
            {
                IssuesListMilestonesState.All => "all",
                IssuesListMilestonesState.Closed => "closed",
                IssuesListMilestonesState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListMilestonesState? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListMilestonesState.All,
                "closed" => IssuesListMilestonesState.Closed,
                "open" => IssuesListMilestonesState.Open,
                _ => null,
            };
        }
    }
}