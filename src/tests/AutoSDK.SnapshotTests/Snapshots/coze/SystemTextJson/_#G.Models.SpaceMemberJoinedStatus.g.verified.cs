//HintName: G.Models.SpaceMemberJoinedStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpaceMemberJoinedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Applied,
        /// <summary>
        /// 
        /// </summary>
        Joined,
        /// <summary>
        /// 
        /// </summary>
        NotJoined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpaceMemberJoinedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpaceMemberJoinedStatus value)
        {
            return value switch
            {
                SpaceMemberJoinedStatus.Applied => "applied",
                SpaceMemberJoinedStatus.Joined => "joined",
                SpaceMemberJoinedStatus.NotJoined => "not_joined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpaceMemberJoinedStatus? ToEnum(string value)
        {
            return value switch
            {
                "applied" => SpaceMemberJoinedStatus.Applied,
                "joined" => SpaceMemberJoinedStatus.Joined,
                "not_joined" => SpaceMemberJoinedStatus.NotJoined,
                _ => null,
            };
        }
    }
}