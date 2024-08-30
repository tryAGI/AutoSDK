//HintName: G.Models.StreamSentinelData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamSentinelData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="[DONE]")]
        DONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamSentinelDataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamSentinelData value)
        {
            return value switch
            {
                StreamSentinelData.DONE => "[DONE]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamSentinelData? ToEnum(string value)
        {
            return value switch
            {
                "[DONE]" => StreamSentinelData.DONE,
                _ => null,
            };
        }
    }
}