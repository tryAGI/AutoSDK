//HintName: G.Models.MessageDeltaContentTextAnnotationsFilePathObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_path`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentTextAnnotationsFilePathObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path")]
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentTextAnnotationsFilePathObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentTextAnnotationsFilePathObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextAnnotationsFilePathObjectType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentTextAnnotationsFilePathObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_path" => MessageDeltaContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}