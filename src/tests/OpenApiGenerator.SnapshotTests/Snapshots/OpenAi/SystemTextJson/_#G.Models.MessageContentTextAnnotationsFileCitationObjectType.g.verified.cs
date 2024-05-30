//HintName: G.Models.MessageContentTextAnnotationsFileCitationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_citation`.
    /// </summary>
    public enum MessageContentTextAnnotationsFileCitationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    public static class MessageContentTextAnnotationsFileCitationObjectTypeExtensions
    {
        public static string ToValueString(this MessageContentTextAnnotationsFileCitationObjectType value)
        {
            return value switch
            {
                MessageContentTextAnnotationsFileCitationObjectType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextAnnotationsFileCitationObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextAnnotationsFileCitationObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}