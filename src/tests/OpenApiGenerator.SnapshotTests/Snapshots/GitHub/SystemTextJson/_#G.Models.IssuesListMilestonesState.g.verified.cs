//HintName: G.Models.IssuesListMilestonesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: open
    /// </summary>
    public enum IssuesListMilestonesState
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
    public static class IssuesListMilestonesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListMilestonesState value)
        {
            return value switch
            {
                IssuesListMilestonesState.Open => "open",
                IssuesListMilestonesState.Closed => "closed",
                IssuesListMilestonesState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListMilestonesState ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesListMilestonesState.Open,
                "closed" => IssuesListMilestonesState.Closed,
                "all" => IssuesListMilestonesState.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}