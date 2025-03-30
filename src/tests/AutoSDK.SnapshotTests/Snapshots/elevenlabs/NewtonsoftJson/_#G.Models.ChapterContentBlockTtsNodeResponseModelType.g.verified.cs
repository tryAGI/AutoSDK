//HintName: G.Models.ChapterContentBlockTtsNodeResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChapterContentBlockTtsNodeResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts_node")]
        TtsNode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterContentBlockTtsNodeResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterContentBlockTtsNodeResponseModelType value)
        {
            return value switch
            {
                ChapterContentBlockTtsNodeResponseModelType.TtsNode => "tts_node",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterContentBlockTtsNodeResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "tts_node" => ChapterContentBlockTtsNodeResponseModelType.TtsNode,
                _ => null,
            };
        }
    }
}