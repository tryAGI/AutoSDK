//HintName: G.Models.WrittenFormRecognitionResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// What kind of object this is. See #/Definitions/RecognitionResult for definitions of the enums.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WrittenFormRecognitionResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WrittenFormRecognitionResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WrittenFormRecognitionResultType value)
        {
            return value switch
            {
                WrittenFormRecognitionResultType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WrittenFormRecognitionResultType? ToEnum(string value)
        {
            return value switch
            {
                "word" => WrittenFormRecognitionResultType.Word,
                _ => null,
            };
        }
    }
}