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
        All,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
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
                IssuesListState.All => "all",
                IssuesListState.Closed => "closed",
                IssuesListState.Open => "open",
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
                "all" => IssuesListState.All,
                "closed" => IssuesListState.Closed,
                "open" => IssuesListState.Open,
                _ => null,
            };
        }
    }
}