//HintName: G.Models.MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.<br/>
    /// Default Value: open<br/>
    /// Example: open
    /// </summary>
    public enum MilestoneState
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
    public static class MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MilestoneState value)
        {
            return value switch
            {
                MilestoneState.Closed => "closed",
                MilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => MilestoneState.Closed,
                "open" => MilestoneState.Open,
                _ => null,
            };
        }
    }
}