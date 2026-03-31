//HintName: G.Models.LLMConfigCreateDtoVariant2CustomBasicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigCreateDtoVariant2CustomBasicType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant2CustomBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant2CustomBasicType value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant2CustomBasicType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant2CustomBasicType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => LLMConfigCreateDtoVariant2CustomBasicType.Basic,
                _ => null,
            };
        }
    }
}