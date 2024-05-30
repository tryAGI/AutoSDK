//HintName: G.Models.StreamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of stream. Possible values are:  
    ///   
    /// * live
    ///   
    /// If an error occurs, this field is set to an empty string.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live")]
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamType value)
        {
            return value switch
            {
                StreamType.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamType ToEnum(string value)
        {
            return value switch
            {
                "live" => StreamType.Live,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}