//HintName: G.Models.IssuesUpdateRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The open or closed state of the issue.
    /// </summary>
    public enum IssuesUpdateRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesUpdateRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestState value)
        {
            return value switch
            {
                IssuesUpdateRequestState.Open => "open",
                IssuesUpdateRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesUpdateRequestState.Open,
                "closed" => IssuesUpdateRequestState.Closed,
                _ => null,
            };
        }
    }
}