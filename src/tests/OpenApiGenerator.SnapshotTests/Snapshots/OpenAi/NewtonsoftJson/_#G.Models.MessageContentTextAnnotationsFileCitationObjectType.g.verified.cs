//HintName: G.Models.MessageContentTextAnnotationsFileCitationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_citation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentTextAnnotationsFileCitationObjectType
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
    public static class MessageContentTextAnnotationsFileCitationObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentTextAnnotationsFileCitationObjectType value)
        {
            return value switch
            {
                MessageContentTextAnnotationsFileCitationObjectType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentTextAnnotationsFileCitationObjectType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageContentTextAnnotationsFileCitationObjectType.FileCitation,
                _ => null,
            };
        }
    }
}