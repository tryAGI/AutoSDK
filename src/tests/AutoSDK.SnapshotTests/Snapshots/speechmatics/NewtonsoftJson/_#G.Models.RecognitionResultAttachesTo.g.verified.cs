//HintName: G.Models.RecognitionResultAttachesTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Attachment direction of the punctuation mark. This only applies to punctuation marks. This information can be used to produce a well-formed text representation by placing the `word_delimiter` from `language_pack_info` on the correct side of the punctuation mark.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RecognitionResultAttachesTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="both")]
        Both,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="next")]
        Next,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="previous")]
        Previous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecognitionResultAttachesToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecognitionResultAttachesTo value)
        {
            return value switch
            {
                RecognitionResultAttachesTo.Both => "both",
                RecognitionResultAttachesTo.Next => "next",
                RecognitionResultAttachesTo.None => "none",
                RecognitionResultAttachesTo.Previous => "previous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecognitionResultAttachesTo? ToEnum(string value)
        {
            return value switch
            {
                "both" => RecognitionResultAttachesTo.Both,
                "next" => RecognitionResultAttachesTo.Next,
                "none" => RecognitionResultAttachesTo.None,
                "previous" => RecognitionResultAttachesTo.Previous,
                _ => null,
            };
        }
    }
}