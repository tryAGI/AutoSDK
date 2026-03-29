//HintName: G.Models.RichTextAnimationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Animation style - animate by character or by word. Only applicable for typewriter and shift animations.<br/>
    /// Example: character
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichTextAnimationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="character")]
        Character,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAnimationStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAnimationStyle value)
        {
            return value switch
            {
                RichTextAnimationStyle.Character => "character",
                RichTextAnimationStyle.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAnimationStyle? ToEnum(string value)
        {
            return value switch
            {
                "character" => RichTextAnimationStyle.Character,
                "word" => RichTextAnimationStyle.Word,
                _ => null,
            };
        }
    }
}