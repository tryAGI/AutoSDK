//HintName: G.Models.TruncationEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TruncationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TruncationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TruncationEnum value)
        {
            return value switch
            {
                TruncationEnum.Auto => "auto",
                TruncationEnum.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TruncationEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TruncationEnum.Auto,
                "disabled" => TruncationEnum.Disabled,
                _ => null,
            };
        }
    }
}