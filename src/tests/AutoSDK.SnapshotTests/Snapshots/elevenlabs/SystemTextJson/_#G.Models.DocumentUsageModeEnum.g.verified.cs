//HintName: G.Models.DocumentUsageModeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocumentUsageModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentUsageModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentUsageModeEnum value)
        {
            return value switch
            {
                DocumentUsageModeEnum.Prompt => "prompt",
                DocumentUsageModeEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentUsageModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => DocumentUsageModeEnum.Prompt,
                "auto" => DocumentUsageModeEnum.Auto,
                _ => null,
            };
        }
    }
}