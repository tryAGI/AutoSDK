//HintName: G.Models.MessageDeltaContentTextAnnotationsFileCitationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_citation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentTextAnnotationsFileCitationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_citation")]
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentTextAnnotationsFileCitationObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentTextAnnotationsFileCitationObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextAnnotationsFileCitationObjectType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentTextAnnotationsFileCitationObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageDeltaContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}