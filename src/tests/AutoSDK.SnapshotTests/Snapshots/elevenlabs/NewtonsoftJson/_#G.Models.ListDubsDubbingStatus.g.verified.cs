//HintName: G.Models.ListDubsDubbingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// What state the dub is currently in.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListDubsDubbingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbed")]
        Dubbed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing")]
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsDubbingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsDubbingStatus value)
        {
            return value switch
            {
                ListDubsDubbingStatus.Dubbed => "dubbed",
                ListDubsDubbingStatus.Dubbing => "dubbing",
                ListDubsDubbingStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsDubbingStatus? ToEnum(string value)
        {
            return value switch
            {
                "dubbed" => ListDubsDubbingStatus.Dubbed,
                "dubbing" => ListDubsDubbingStatus.Dubbing,
                "failed" => ListDubsDubbingStatus.Failed,
                _ => null,
            };
        }
    }
}