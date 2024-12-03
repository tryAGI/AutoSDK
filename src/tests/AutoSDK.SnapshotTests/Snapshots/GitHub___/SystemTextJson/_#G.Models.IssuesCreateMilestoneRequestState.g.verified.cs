//HintName: G.Models.IssuesCreateMilestoneRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone. Either `open` or `closed`.<br/>
    /// Default Value: open
    /// </summary>
    public enum IssuesCreateMilestoneRequestState
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
    public static class IssuesCreateMilestoneRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesCreateMilestoneRequestState value)
        {
            return value switch
            {
                IssuesCreateMilestoneRequestState.Open => "open",
                IssuesCreateMilestoneRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesCreateMilestoneRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesCreateMilestoneRequestState.Open,
                "closed" => IssuesCreateMilestoneRequestState.Closed,
                _ => null,
            };
        }
    }
}