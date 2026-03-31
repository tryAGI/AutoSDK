//HintName: G.Models.TopicMapDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicMapDataType
    {
        /// <summary>
        /// 
        /// </summary>
        TopicMap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapDataType value)
        {
            return value switch
            {
                TopicMapDataType.TopicMap => "topic_map",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapDataType? ToEnum(string value)
        {
            return value switch
            {
                "topic_map" => TopicMapDataType.TopicMap,
                _ => null,
            };
        }
    }
}