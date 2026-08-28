//HintName: G.Models.InstructType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instruction format type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InstructType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="airoboros")]
        Airoboros,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alpaca")]
        Alpaca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alpaca-modif")]
        AlpacaModif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatml")]
        Chatml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude")]
        Claude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code-llama")]
        CodeLlama,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek-r1")]
        DeepseekR1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek-v3.1")]
        DeepseekV31,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemma")]
        Gemma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama2")]
        Llama2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama3")]
        Llama3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nemotron")]
        Nemotron,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neural")]
        Neural,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openchat")]
        Openchat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phi3")]
        Phi3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="qwen3")]
        Qwen3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="qwq")]
        Qwq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rwkv")]
        Rwkv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vicuna")]
        Vicuna,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zephyr")]
        Zephyr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstructTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructType value)
        {
            return value switch
            {
                InstructType.Airoboros => "airoboros",
                InstructType.Alpaca => "alpaca",
                InstructType.AlpacaModif => "alpaca-modif",
                InstructType.Chatml => "chatml",
                InstructType.Claude => "claude",
                InstructType.CodeLlama => "code-llama",
                InstructType.DeepseekR1 => "deepseek-r1",
                InstructType.DeepseekV31 => "deepseek-v3.1",
                InstructType.Gemma => "gemma",
                InstructType.Llama2 => "llama2",
                InstructType.Llama3 => "llama3",
                InstructType.Mistral => "mistral",
                InstructType.Nemotron => "nemotron",
                InstructType.Neural => "neural",
                InstructType.None => "none",
                InstructType.Openchat => "openchat",
                InstructType.Phi3 => "phi3",
                InstructType.Qwen3 => "qwen3",
                InstructType.Qwq => "qwq",
                InstructType.Rwkv => "rwkv",
                InstructType.Vicuna => "vicuna",
                InstructType.Zephyr => "zephyr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructType? ToEnum(string value)
        {
            return value switch
            {
                "airoboros" => InstructType.Airoboros,
                "alpaca" => InstructType.Alpaca,
                "alpaca-modif" => InstructType.AlpacaModif,
                "chatml" => InstructType.Chatml,
                "claude" => InstructType.Claude,
                "code-llama" => InstructType.CodeLlama,
                "deepseek-r1" => InstructType.DeepseekR1,
                "deepseek-v3.1" => InstructType.DeepseekV31,
                "gemma" => InstructType.Gemma,
                "llama2" => InstructType.Llama2,
                "llama3" => InstructType.Llama3,
                "mistral" => InstructType.Mistral,
                "nemotron" => InstructType.Nemotron,
                "neural" => InstructType.Neural,
                "none" => InstructType.None,
                "openchat" => InstructType.Openchat,
                "phi3" => InstructType.Phi3,
                "qwen3" => InstructType.Qwen3,
                "qwq" => InstructType.Qwq,
                "rwkv" => InstructType.Rwkv,
                "vicuna" => InstructType.Vicuna,
                "zephyr" => InstructType.Zephyr,
                _ => null,
            };
        }
    }
}