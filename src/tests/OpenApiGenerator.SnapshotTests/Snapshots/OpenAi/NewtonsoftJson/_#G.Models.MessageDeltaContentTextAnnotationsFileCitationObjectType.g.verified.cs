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

    public static class MessageDeltaContentTextAnnotationsFileCitationObjectTypeExtensions
    {
        public static string ToValueString(this MessageDeltaContentTextAnnotationsFileCitationObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextAnnotationsFileCitationObjectType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextAnnotationsFileCitationObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageDeltaContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextAnnotationsFileCitationObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}