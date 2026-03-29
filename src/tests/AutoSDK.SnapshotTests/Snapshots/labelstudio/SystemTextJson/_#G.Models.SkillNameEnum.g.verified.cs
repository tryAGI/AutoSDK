//HintName: G.Models.SkillNameEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `TextClassification` - TextClassification<br/>
    /// * `NamedEntityRecognition` - NamedEntityRecognition
    /// </summary>
    public enum SkillNameEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NamedEntityRecognition,
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillNameEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillNameEnum value)
        {
            return value switch
            {
                SkillNameEnum.NamedEntityRecognition => "NamedEntityRecognition",
                SkillNameEnum.TextClassification => "TextClassification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillNameEnum? ToEnum(string value)
        {
            return value switch
            {
                "NamedEntityRecognition" => SkillNameEnum.NamedEntityRecognition,
                "TextClassification" => SkillNameEnum.TextClassification,
                _ => null,
            };
        }
    }
}