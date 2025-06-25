//HintName: G.Models.IssuesListState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum IssuesListState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListState value)
        {
            return value switch
            {
                IssuesListState.Open => "open",
                IssuesListState.Closed => "closed",
                IssuesListState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListState? ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesListState.Open,
                "closed" => IssuesListState.Closed,
                "all" => IssuesListState.All,
                _ => null,
            };
        }
    }
}