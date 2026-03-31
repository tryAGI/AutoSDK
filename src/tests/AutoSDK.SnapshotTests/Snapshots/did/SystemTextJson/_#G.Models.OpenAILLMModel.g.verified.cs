//HintName: G.Models.OpenAILLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum OpenAILLMModel
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
    public static class OpenAILLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAILLMModel value)
        {
            return value switch
            {
                OpenAILLMModel.Gpt41 => "gpt-4.1",
                OpenAILLMModel.Gpt41Mini => "gpt-4.1-mini",
                OpenAILLMModel.Gpt41Nano => "gpt-4.1-nano",
                OpenAILLMModel.Gpt4oGlobal => "gpt-4o-global",
                OpenAILLMModel.Gpt4oMini => "gpt-4o-mini",
                OpenAILLMModel.Gpt5Mini => "gpt-5-mini",
                OpenAILLMModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAILLMModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => OpenAILLMModel.Gpt41,
                "gpt-4.1-mini" => OpenAILLMModel.Gpt41Mini,
                "gpt-4.1-nano" => OpenAILLMModel.Gpt41Nano,
                "gpt-4o-global" => OpenAILLMModel.Gpt4oGlobal,
                "gpt-4o-mini" => OpenAILLMModel.Gpt4oMini,
                "gpt-5-mini" => OpenAILLMModel.Gpt5Mini,
                "gpt-5-nano" => OpenAILLMModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}