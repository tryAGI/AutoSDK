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
    public enum StreamType
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    public static class StreamTypeExtensions
    {
        public static string ToValueString(this StreamType value)
        {
            return value switch
            {
                StreamType.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static StreamType ToEnum(string value)
        {
            return value switch
            {
                "live" => StreamType.Live,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static StreamType ToEnum(int value)
        {
            return value switch
            {
                0 => StreamType.Live,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}