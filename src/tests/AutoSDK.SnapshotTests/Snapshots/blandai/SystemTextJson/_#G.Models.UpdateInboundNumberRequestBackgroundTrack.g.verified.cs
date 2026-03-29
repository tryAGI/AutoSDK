//HintName: G.Models.UpdateInboundNumberRequestBackgroundTrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInboundNumberRequestBackgroundTrack
    {
        /// <summary>
        /// 
        /// </summary>
        Cafe,
        /// <summary>
        /// 
        /// </summary>
        Null,
        /// <summary>
        /// 
        /// </summary>
        Office,
        /// <summary>
        /// 
        /// </summary>
        Restaurant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInboundNumberRequestBackgroundTrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboundNumberRequestBackgroundTrack value)
        {
            return value switch
            {
                UpdateInboundNumberRequestBackgroundTrack.Cafe => "cafe",
                UpdateInboundNumberRequestBackgroundTrack.Null => "null",
                UpdateInboundNumberRequestBackgroundTrack.Office => "office",
                UpdateInboundNumberRequestBackgroundTrack.Restaurant => "restaurant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboundNumberRequestBackgroundTrack? ToEnum(string value)
        {
            return value switch
            {
                "cafe" => UpdateInboundNumberRequestBackgroundTrack.Cafe,
                "null" => UpdateInboundNumberRequestBackgroundTrack.Null,
                "office" => UpdateInboundNumberRequestBackgroundTrack.Office,
                "restaurant" => UpdateInboundNumberRequestBackgroundTrack.Restaurant,
                _ => null,
            };
        }
    }
}