//HintName: G.Models.OpenAILLMCreateDtoModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum OpenAILLMCreateDtoModel
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
    public static class OpenAILLMCreateDtoModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAILLMCreateDtoModel value)
        {
            return value switch
            {
                OpenAILLMCreateDtoModel.Gpt41 => "gpt-4.1",
                OpenAILLMCreateDtoModel.Gpt41Mini => "gpt-4.1-mini",
                OpenAILLMCreateDtoModel.Gpt41Nano => "gpt-4.1-nano",
                OpenAILLMCreateDtoModel.Gpt4oGlobal => "gpt-4o-global",
                OpenAILLMCreateDtoModel.Gpt4oMini => "gpt-4o-mini",
                OpenAILLMCreateDtoModel.Gpt5Mini => "gpt-5-mini",
                OpenAILLMCreateDtoModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAILLMCreateDtoModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => OpenAILLMCreateDtoModel.Gpt41,
                "gpt-4.1-mini" => OpenAILLMCreateDtoModel.Gpt41Mini,
                "gpt-4.1-nano" => OpenAILLMCreateDtoModel.Gpt41Nano,
                "gpt-4o-global" => OpenAILLMCreateDtoModel.Gpt4oGlobal,
                "gpt-4o-mini" => OpenAILLMCreateDtoModel.Gpt4oMini,
                "gpt-5-mini" => OpenAILLMCreateDtoModel.Gpt5Mini,
                "gpt-5-nano" => OpenAILLMCreateDtoModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}