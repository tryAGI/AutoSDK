//HintName: G.Models.PullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.<br/>
    /// Example: open
    /// </summary>
    public enum PullRequestState
    {
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
    public static class PullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestState value)
        {
            return value switch
            {
                PullRequestState.Closed => "closed",
                PullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => PullRequestState.Closed,
                "open" => PullRequestState.Open,
                _ => null,
            };
        }
    }
}