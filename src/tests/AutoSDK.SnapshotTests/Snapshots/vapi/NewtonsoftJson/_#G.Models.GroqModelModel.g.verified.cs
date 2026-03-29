//HintName: G.Models.GroqModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GroqModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compound-beta")]
        CompoundBeta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compound-beta-mini")]
        CompoundBetaMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek-r1-distill-llama-70b")]
        DeepseekR1DistillLlama70b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemma2-9b-it")]
        Gemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-3.1-405b-reasoning")]
        Llama31405bReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-3.1-8b-instant")]
        Llama318bInstant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-3.3-70b-versatile")]
        Llama3370bVersatile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama3-70b-8192")]
        Llama370b8192,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama3-8b-8192")]
        Llama38b8192,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="meta-llama/llama-4-maverick-17b-128e-instruct")]
        MetaLlamaLlama4Maverick17b128eInstruct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="meta-llama/llama-4-scout-17b-16e-instruct")]
        MetaLlamaLlama4Scout17b16eInstruct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral-saba-24b")]
        MistralSaba24b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moonshotai/kimi-k2-instruct-0905")]
        MoonshotaiKimiK2Instruct0905,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai/gpt-oss-120b")]
        OpenaiGptOss120b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai/gpt-oss-20b")]
        OpenaiGptOss20b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroqModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqModelModel value)
        {
            return value switch
            {
                GroqModelModel.CompoundBeta => "compound-beta",
                GroqModelModel.CompoundBetaMini => "compound-beta-mini",
                GroqModelModel.DeepseekR1DistillLlama70b => "deepseek-r1-distill-llama-70b",
                GroqModelModel.Gemma29bIt => "gemma2-9b-it",
                GroqModelModel.Llama31405bReasoning => "llama-3.1-405b-reasoning",
                GroqModelModel.Llama318bInstant => "llama-3.1-8b-instant",
                GroqModelModel.Llama3370bVersatile => "llama-3.3-70b-versatile",
                GroqModelModel.Llama370b8192 => "llama3-70b-8192",
                GroqModelModel.Llama38b8192 => "llama3-8b-8192",
                GroqModelModel.MetaLlamaLlama4Maverick17b128eInstruct => "meta-llama/llama-4-maverick-17b-128e-instruct",
                GroqModelModel.MetaLlamaLlama4Scout17b16eInstruct => "meta-llama/llama-4-scout-17b-16e-instruct",
                GroqModelModel.MistralSaba24b => "mistral-saba-24b",
                GroqModelModel.MoonshotaiKimiK2Instruct0905 => "moonshotai/kimi-k2-instruct-0905",
                GroqModelModel.OpenaiGptOss120b => "openai/gpt-oss-120b",
                GroqModelModel.OpenaiGptOss20b => "openai/gpt-oss-20b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqModelModel? ToEnum(string value)
        {
            return value switch
            {
                "compound-beta" => GroqModelModel.CompoundBeta,
                "compound-beta-mini" => GroqModelModel.CompoundBetaMini,
                "deepseek-r1-distill-llama-70b" => GroqModelModel.DeepseekR1DistillLlama70b,
                "gemma2-9b-it" => GroqModelModel.Gemma29bIt,
                "llama-3.1-405b-reasoning" => GroqModelModel.Llama31405bReasoning,
                "llama-3.1-8b-instant" => GroqModelModel.Llama318bInstant,
                "llama-3.3-70b-versatile" => GroqModelModel.Llama3370bVersatile,
                "llama3-70b-8192" => GroqModelModel.Llama370b8192,
                "llama3-8b-8192" => GroqModelModel.Llama38b8192,
                "meta-llama/llama-4-maverick-17b-128e-instruct" => GroqModelModel.MetaLlamaLlama4Maverick17b128eInstruct,
                "meta-llama/llama-4-scout-17b-16e-instruct" => GroqModelModel.MetaLlamaLlama4Scout17b16eInstruct,
                "mistral-saba-24b" => GroqModelModel.MistralSaba24b,
                "moonshotai/kimi-k2-instruct-0905" => GroqModelModel.MoonshotaiKimiK2Instruct0905,
                "openai/gpt-oss-120b" => GroqModelModel.OpenaiGptOss120b,
                "openai/gpt-oss-20b" => GroqModelModel.OpenaiGptOss20b,
                _ => null,
            };
        }
    }
}