//HintName: G.Models.NullableMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.<br/>
    /// Default Value: open<br/>
    /// Example: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
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
                NullableMilestoneState.Closed => "closed",
                NullableMilestoneState.Open => "open",
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
                "closed" => NullableMilestoneState.Closed,
                "open" => NullableMilestoneState.Open,
                _ => null,
            };
        }
    }
}