//HintName: G.Models.ModelArchitectureInstructType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instruction format type
    /// </summary>
    public enum ModelArchitectureInstructType
    {
        /// <summary>
        /// 
        /// </summary>
        Airoboros,
        /// <summary>
        /// 
        /// </summary>
        Alpaca,
        /// <summary>
        /// 
        /// </summary>
        AlpacaModif,
        /// <summary>
        /// 
        /// </summary>
        Chatml,
        /// <summary>
        /// 
        /// </summary>
        Claude,
        /// <summary>
        /// 
        /// </summary>
        CodeLlama,
        /// <summary>
        /// 
        /// </summary>
        DeepseekR1,
        /// <summary>
        /// 
        /// </summary>
        DeepseekV31,
        /// <summary>
        /// 
        /// </summary>
        Gemma,
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
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Nemotron,
        /// <summary>
        /// 
        /// </summary>
        Neural,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Openchat,
        /// <summary>
        /// 
        /// </summary>
        Phi3,
        /// <summary>
        /// 
        /// </summary>
        Qwen3,
        /// <summary>
        /// 
        /// </summary>
        Qwq,
        /// <summary>
        /// 
        /// </summary>
        Rwkv,
        /// <summary>
        /// 
        /// </summary>
        Vicuna,
        /// <summary>
        /// 
        /// </summary>
        Zephyr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelArchitectureInstructTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelArchitectureInstructType value)
        {
            return value switch
            {
                ModelArchitectureInstructType.Airoboros => "airoboros",
                ModelArchitectureInstructType.Alpaca => "alpaca",
                ModelArchitectureInstructType.AlpacaModif => "alpaca-modif",
                ModelArchitectureInstructType.Chatml => "chatml",
                ModelArchitectureInstructType.Claude => "claude",
                ModelArchitectureInstructType.CodeLlama => "code-llama",
                ModelArchitectureInstructType.DeepseekR1 => "deepseek-r1",
                ModelArchitectureInstructType.DeepseekV31 => "deepseek-v3.1",
                ModelArchitectureInstructType.Gemma => "gemma",
                ModelArchitectureInstructType.Llama2 => "llama2",
                ModelArchitectureInstructType.Llama3 => "llama3",
                ModelArchitectureInstructType.Mistral => "mistral",
                ModelArchitectureInstructType.Nemotron => "nemotron",
                ModelArchitectureInstructType.Neural => "neural",
                ModelArchitectureInstructType.None => "none",
                ModelArchitectureInstructType.Openchat => "openchat",
                ModelArchitectureInstructType.Phi3 => "phi3",
                ModelArchitectureInstructType.Qwen3 => "qwen3",
                ModelArchitectureInstructType.Qwq => "qwq",
                ModelArchitectureInstructType.Rwkv => "rwkv",
                ModelArchitectureInstructType.Vicuna => "vicuna",
                ModelArchitectureInstructType.Zephyr => "zephyr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelArchitectureInstructType? ToEnum(string value)
        {
            return value switch
            {
                "airoboros" => ModelArchitectureInstructType.Airoboros,
                "alpaca" => ModelArchitectureInstructType.Alpaca,
                "alpaca-modif" => ModelArchitectureInstructType.AlpacaModif,
                "chatml" => ModelArchitectureInstructType.Chatml,
                "claude" => ModelArchitectureInstructType.Claude,
                "code-llama" => ModelArchitectureInstructType.CodeLlama,
                "deepseek-r1" => ModelArchitectureInstructType.DeepseekR1,
                "deepseek-v3.1" => ModelArchitectureInstructType.DeepseekV31,
                "gemma" => ModelArchitectureInstructType.Gemma,
                "llama2" => ModelArchitectureInstructType.Llama2,
                "llama3" => ModelArchitectureInstructType.Llama3,
                "mistral" => ModelArchitectureInstructType.Mistral,
                "nemotron" => ModelArchitectureInstructType.Nemotron,
                "neural" => ModelArchitectureInstructType.Neural,
                "none" => ModelArchitectureInstructType.None,
                "openchat" => ModelArchitectureInstructType.Openchat,
                "phi3" => ModelArchitectureInstructType.Phi3,
                "qwen3" => ModelArchitectureInstructType.Qwen3,
                "qwq" => ModelArchitectureInstructType.Qwq,
                "rwkv" => ModelArchitectureInstructType.Rwkv,
                "vicuna" => ModelArchitectureInstructType.Vicuna,
                "zephyr" => ModelArchitectureInstructType.Zephyr,
                _ => null,
            };
        }
    }
}