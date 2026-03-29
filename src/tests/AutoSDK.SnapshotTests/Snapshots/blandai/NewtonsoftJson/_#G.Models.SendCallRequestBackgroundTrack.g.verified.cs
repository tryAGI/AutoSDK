//HintName: G.Models.SendCallRequestBackgroundTrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Background audio track
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendCallRequestBackgroundTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cafe")]
        Cafe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="null")]
        Null,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="office")]
        Office,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="restaurant")]
        Restaurant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendCallRequestBackgroundTrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendCallRequestBackgroundTrack value)
        {
            return value switch
            {
                SendCallRequestBackgroundTrack.Cafe => "cafe",
                SendCallRequestBackgroundTrack.Null => "null",
                SendCallRequestBackgroundTrack.Office => "office",
                SendCallRequestBackgroundTrack.Restaurant => "restaurant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendCallRequestBackgroundTrack? ToEnum(string value)
        {
            return value switch
            {
                "cafe" => SendCallRequestBackgroundTrack.Cafe,
                "null" => SendCallRequestBackgroundTrack.Null,
                "office" => SendCallRequestBackgroundTrack.Office,
                "restaurant" => SendCallRequestBackgroundTrack.Restaurant,
                _ => null,
            };
        }
    }
}