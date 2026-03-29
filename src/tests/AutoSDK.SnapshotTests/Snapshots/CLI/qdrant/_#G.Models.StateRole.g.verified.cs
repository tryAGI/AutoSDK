//HintName: G.Models.StateRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role of the peer in the consensus
    /// </summary>
    public enum StateRole
    {
        /// <summary>
        /// 
        /// </summary>
        Candidate,
        /// <summary>
        /// 
        /// </summary>
        Follower,
        /// <summary>
        /// 
        /// </summary>
        Leader,
        /// <summary>
        /// 
        /// </summary>
        PreCandidate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateRole value)
        {
            return value switch
            {
                StateRole.Candidate => "Candidate",
                StateRole.Follower => "Follower",
                StateRole.Leader => "Leader",
                StateRole.PreCandidate => "PreCandidate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateRole? ToEnum(string value)
        {
            return value switch
            {
                "Candidate" => StateRole.Candidate,
                "Follower" => StateRole.Follower,
                "Leader" => StateRole.Leader,
                "PreCandidate" => StateRole.PreCandidate,
                _ => null,
            };
        }
    }
}