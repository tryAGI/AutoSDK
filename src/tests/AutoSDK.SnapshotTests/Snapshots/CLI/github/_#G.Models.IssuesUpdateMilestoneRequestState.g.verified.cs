﻿//HintName: G.Models.IssuesUpdateMilestoneRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone. Either `open` or `closed`.<br/>
    /// Default Value: open
    /// </summary>
    public enum IssuesUpdateMilestoneRequestState
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
    public static class IssuesUpdateMilestoneRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateMilestoneRequestState value)
        {
            return value switch
            {
                IssuesUpdateMilestoneRequestState.Open => "open",
                IssuesUpdateMilestoneRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateMilestoneRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesUpdateMilestoneRequestState.Open,
                "closed" => IssuesUpdateMilestoneRequestState.Closed,
                _ => null,
            };
        }
    }
}