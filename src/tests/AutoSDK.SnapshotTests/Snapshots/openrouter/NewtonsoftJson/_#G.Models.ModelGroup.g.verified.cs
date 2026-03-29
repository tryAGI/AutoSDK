//HintName: G.Models.ModelGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tokenizer type used by the model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Claude")]
        Claude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Cohere")]
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DeepSeek")]
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT")]
        Gpt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Gemini")]
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Grok")]
        Grok,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Llama2")]
        Llama2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Llama3")]
        Llama3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Llama4")]
        Llama4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Media")]
        Media,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Nova")]
        Nova,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PaLM")]
        PaLM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Qwen")]
        Qwen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Qwen3")]
        Qwen3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RWKV")]
        Rwkv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Router")]
        Router,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Yi")]
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