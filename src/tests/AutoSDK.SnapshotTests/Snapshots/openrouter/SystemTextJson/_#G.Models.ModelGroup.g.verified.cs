//HintName: G.Models.ModelGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tokenizer type used by the model
    /// </summary>
    public enum ModelGroup
    {
        /// <summary>
        /// 
        /// </summary>
        Claude,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Gpt,
        /// <summary>
        /// 
        /// </summary>
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        Grok,
        /// <summary>
        /// 
        /// </summary>
        Llama2,
        /// <summary>
        /// 
        /// </summary>
        Llama3,
        /// <summary>
        /// 
        /// </summary>
        Llama4,
        /// <summary>
        /// 
        /// </summary>
        Media,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PaLM,
        /// <summary>
        /// 
        /// </summary>
        Qwen,
        /// <summary>
        /// 
        /// </summary>
        Qwen3,
        /// <summary>
        /// 
        /// </summary>
        Rwkv,
        /// <summary>
        /// 
        /// </summary>
        Router,
        /// <summary>
        /// 
        /// </summary>
        Yi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelGroup value)
        {
            return value switch
            {
                ModelGroup.Claude => "Claude",
                ModelGroup.Cohere => "Cohere",
                ModelGroup.DeepSeek => "DeepSeek",
                ModelGroup.Gpt => "GPT",
                ModelGroup.Gemini => "Gemini",
                ModelGroup.Grok => "Grok",
                ModelGroup.Llama2 => "Llama2",
                ModelGroup.Llama3 => "Llama3",
                ModelGroup.Llama4 => "Llama4",
                ModelGroup.Media => "Media",
                ModelGroup.Mistral => "Mistral",
                ModelGroup.Nova => "Nova",
                ModelGroup.Other => "Other",
                ModelGroup.PaLM => "PaLM",
                ModelGroup.Qwen => "Qwen",
                ModelGroup.Qwen3 => "Qwen3",
                ModelGroup.Rwkv => "RWKV",
                ModelGroup.Router => "Router",
                ModelGroup.Yi => "Yi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelGroup? ToEnum(string value)
        {
            return value switch
            {
                "Claude" => ModelGroup.Claude,
                "Cohere" => ModelGroup.Cohere,
                "DeepSeek" => ModelGroup.DeepSeek,
                "GPT" => ModelGroup.Gpt,
                "Gemini" => ModelGroup.Gemini,
                "Grok" => ModelGroup.Grok,
                "Llama2" => ModelGroup.Llama2,
                "Llama3" => ModelGroup.Llama3,
                "Llama4" => ModelGroup.Llama4,
                "Media" => ModelGroup.Media,
                "Mistral" => ModelGroup.Mistral,
                "Nova" => ModelGroup.Nova,
                "Other" => ModelGroup.Other,
                "PaLM" => ModelGroup.PaLM,
                "Qwen" => ModelGroup.Qwen,
                "Qwen3" => ModelGroup.Qwen3,
                "RWKV" => ModelGroup.Rwkv,
                "Router" => ModelGroup.Router,
                "Yi" => ModelGroup.Yi,
                _ => null,
            };
        }
    }
}