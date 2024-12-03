//HintName: G.Models.DiscussionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current state of the discussion.<br/>
    /// `converting` means that the discussion is being converted from an issue.<br/>
    /// `transferring` means that the discussion is being transferred from another repository.
    /// </summary>
    public enum DiscussionState
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
        Locked,
        /// <summary>
        /// 
        /// </summary>
        Converting,
        /// <summary>
        /// 
        /// </summary>
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