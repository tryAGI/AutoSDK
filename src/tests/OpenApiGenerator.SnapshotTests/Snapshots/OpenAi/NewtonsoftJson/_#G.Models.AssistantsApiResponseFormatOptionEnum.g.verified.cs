//HintName: G.Models.AssistantsApiResponseFormatOptionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantsApiResponseFormatOptionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantsApiResponseFormatOptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsApiResponseFormatOptionEnum value)
        {
            return value switch
            {
                AssistantsApiResponseFormatOptionEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsApiResponseFormatOptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AssistantsApiResponseFormatOptionEnum.Auto,
                _ => null,
            };
        }
    }
}