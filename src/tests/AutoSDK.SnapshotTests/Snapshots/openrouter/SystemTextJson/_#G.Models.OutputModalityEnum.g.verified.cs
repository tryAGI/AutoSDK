//HintName: G.Models.OutputModalityEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputModalityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputModalityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputModalityEnum value)
        {
            return value switch
            {
                OutputModalityEnum.Image => "image",
                OutputModalityEnum.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputModalityEnum? ToEnum(string value)
        {
            return value switch
            {
                "image" => OutputModalityEnum.Image,
                "text" => OutputModalityEnum.Text,
                _ => null,
            };
        }
    }
}