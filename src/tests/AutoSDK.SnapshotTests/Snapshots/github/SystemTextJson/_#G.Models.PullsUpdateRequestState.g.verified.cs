//HintName: G.Models.PullsUpdateRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum PullsUpdateRequestState
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
    public static class PullsUpdateRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsUpdateRequestState value)
        {
            return value switch
            {
                PullsUpdateRequestState.Closed => "closed",
                PullsUpdateRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsUpdateRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => PullsUpdateRequestState.Closed,
                "open" => PullsUpdateRequestState.Open,
                _ => null,
            };
        }
    }
}