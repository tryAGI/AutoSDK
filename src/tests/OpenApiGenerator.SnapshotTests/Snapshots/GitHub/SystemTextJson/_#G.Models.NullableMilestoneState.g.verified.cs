//HintName: G.Models.NullableMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.<br/>
    /// Default Value: open<br/>
    /// Example: open
    /// </summary>
    public enum NullableMilestoneState
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
    public static class NullableMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableMilestoneState value)
        {
            return value switch
            {
                NullableMilestoneState.Open => "open",
                NullableMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => NullableMilestoneState.Open,
                "closed" => NullableMilestoneState.Closed,
                _ => null,
            };
        }
    }
}