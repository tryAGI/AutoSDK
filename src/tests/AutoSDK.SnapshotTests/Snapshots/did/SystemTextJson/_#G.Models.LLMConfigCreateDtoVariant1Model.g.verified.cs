//HintName: G.Models.LLMConfigCreateDtoVariant1Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum LLMConfigCreateDtoVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant1Model value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant1Model.Gpt41 => "gpt-4.1",
                LLMConfigCreateDtoVariant1Model.Gpt41Mini => "gpt-4.1-mini",
                LLMConfigCreateDtoVariant1Model.Gpt41Nano => "gpt-4.1-nano",
                LLMConfigCreateDtoVariant1Model.Gpt4oGlobal => "gpt-4o-global",
                LLMConfigCreateDtoVariant1Model.Gpt4oMini => "gpt-4o-mini",
                LLMConfigCreateDtoVariant1Model.Gpt5Mini => "gpt-5-mini",
                LLMConfigCreateDtoVariant1Model.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => LLMConfigCreateDtoVariant1Model.Gpt41,
                "gpt-4.1-mini" => LLMConfigCreateDtoVariant1Model.Gpt41Mini,
                "gpt-4.1-nano" => LLMConfigCreateDtoVariant1Model.Gpt41Nano,
                "gpt-4o-global" => LLMConfigCreateDtoVariant1Model.Gpt4oGlobal,
                "gpt-4o-mini" => LLMConfigCreateDtoVariant1Model.Gpt4oMini,
                "gpt-5-mini" => LLMConfigCreateDtoVariant1Model.Gpt5Mini,
                "gpt-5-nano" => LLMConfigCreateDtoVariant1Model.Gpt5Nano,
                _ => null,
            };
        }
    }
}