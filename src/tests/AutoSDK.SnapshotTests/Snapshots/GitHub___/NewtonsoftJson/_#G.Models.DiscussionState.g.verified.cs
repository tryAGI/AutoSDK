//HintName: G.Models.DiscussionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current state of the discussion.<br/>
    /// `converting` means that the discussion is being converted from an issue.<br/>
    /// `transferring` means that the discussion is being transferred from another repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="locked")]
        Locked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="converting")]
        Converting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transferring")]
        Transferring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscussionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionState value)
        {
            return value switch
            {
                DiscussionState.Open => "open",
                DiscussionState.Closed => "closed",
                DiscussionState.Locked => "locked",
                DiscussionState.Converting => "converting",
                DiscussionState.Transferring => "transferring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionState? ToEnum(string value)
        {
            return value switch
            {
                "open" => DiscussionState.Open,
                "closed" => DiscussionState.Closed,
                "locked" => DiscussionState.Locked,
                "converting" => DiscussionState.Converting,
                "transferring" => DiscussionState.Transferring,
                _ => null,
            };
        }
    }
}