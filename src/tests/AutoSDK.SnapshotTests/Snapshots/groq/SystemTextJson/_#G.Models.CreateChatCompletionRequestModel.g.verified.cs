//HintName: G.Models.CreateChatCompletionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        CompoundBeta,
        /// <summary>
        /// 
        /// </summary>
        CompoundBetaMini,
        /// <summary>
        /// 
        /// </summary>
        Gemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        Llama318bInstant,
        /// <summary>
        /// 
        /// </summary>
        Llama3370bVersatile,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaLlama4Maverick17b128eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaLlama4Scout17b16eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaLlamaGuard412b,
        /// <summary>
        /// 
        /// </summary>
        MoonshotaiKimiK2Instruct,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGptOss120b,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGptOss20b,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen332b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestModel value)
        {
            return value switch
            {
                CreateChatCompletionRequestModel.CompoundBeta => "compound-beta",
                CreateChatCompletionRequestModel.CompoundBetaMini => "compound-beta-mini",
                CreateChatCompletionRequestModel.Gemma29bIt => "gemma2-9b-it",
                CreateChatCompletionRequestModel.Llama318bInstant => "llama-3.1-8b-instant",
                CreateChatCompletionRequestModel.Llama3370bVersatile => "llama-3.3-70b-versatile",
                CreateChatCompletionRequestModel.MetaLlamaLlama4Maverick17b128eInstruct => "meta-llama/llama-4-maverick-17b-128e-instruct",
                CreateChatCompletionRequestModel.MetaLlamaLlama4Scout17b16eInstruct => "meta-llama/llama-4-scout-17b-16e-instruct",
                CreateChatCompletionRequestModel.MetaLlamaLlamaGuard412b => "meta-llama/llama-guard-4-12b",
                CreateChatCompletionRequestModel.MoonshotaiKimiK2Instruct => "moonshotai/kimi-k2-instruct",
                CreateChatCompletionRequestModel.OpenaiGptOss120b => "openai/gpt-oss-120b",
                CreateChatCompletionRequestModel.OpenaiGptOss20b => "openai/gpt-oss-20b",
                CreateChatCompletionRequestModel.QwenQwen332b => "qwen/qwen3-32b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "compound-beta" => CreateChatCompletionRequestModel.CompoundBeta,
                "compound-beta-mini" => CreateChatCompletionRequestModel.CompoundBetaMini,
                "gemma2-9b-it" => CreateChatCompletionRequestModel.Gemma29bIt,
                "llama-3.1-8b-instant" => CreateChatCompletionRequestModel.Llama318bInstant,
                "llama-3.3-70b-versatile" => CreateChatCompletionRequestModel.Llama3370bVersatile,
                "meta-llama/llama-4-maverick-17b-128e-instruct" => CreateChatCompletionRequestModel.MetaLlamaLlama4Maverick17b128eInstruct,
                "meta-llama/llama-4-scout-17b-16e-instruct" => CreateChatCompletionRequestModel.MetaLlamaLlama4Scout17b16eInstruct,
                "meta-llama/llama-guard-4-12b" => CreateChatCompletionRequestModel.MetaLlamaLlamaGuard412b,
                "moonshotai/kimi-k2-instruct" => CreateChatCompletionRequestModel.MoonshotaiKimiK2Instruct,
                "openai/gpt-oss-120b" => CreateChatCompletionRequestModel.OpenaiGptOss120b,
                "openai/gpt-oss-20b" => CreateChatCompletionRequestModel.OpenaiGptOss20b,
                "qwen/qwen3-32b" => CreateChatCompletionRequestModel.QwenQwen332b,
                _ => null,
            };
        }
    }
}