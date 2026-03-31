//HintName: G.Models.LLMConfigOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum LLMConfigOpenAIModel
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
    public static class LLMConfigOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigOpenAIModel value)
        {
            return value switch
            {
                LLMConfigOpenAIModel.Gpt41 => "gpt-4.1",
                LLMConfigOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                LLMConfigOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                LLMConfigOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                LLMConfigOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                LLMConfigOpenAIModel.Gpt5Mini => "gpt-5-mini",
                LLMConfigOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => LLMConfigOpenAIModel.Gpt41,
                "gpt-4.1-mini" => LLMConfigOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => LLMConfigOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => LLMConfigOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => LLMConfigOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => LLMConfigOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => LLMConfigOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}