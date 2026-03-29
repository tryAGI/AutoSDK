//HintName: G.Models.InstructType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instruction format type
    /// </summary>
    public enum InstructType2
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
    public static class InstructType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructType2 value)
        {
            return value switch
            {
                InstructType2.Airoboros => "airoboros",
                InstructType2.Alpaca => "alpaca",
                InstructType2.AlpacaModif => "alpaca-modif",
                InstructType2.Chatml => "chatml",
                InstructType2.Claude => "claude",
                InstructType2.CodeLlama => "code-llama",
                InstructType2.DeepseekR1 => "deepseek-r1",
                InstructType2.DeepseekV31 => "deepseek-v3.1",
                InstructType2.Gemma => "gemma",
                InstructType2.Llama2 => "llama2",
                InstructType2.Llama3 => "llama3",
                InstructType2.Mistral => "mistral",
                InstructType2.Nemotron => "nemotron",
                InstructType2.Neural => "neural",
                InstructType2.None => "none",
                InstructType2.Openchat => "openchat",
                InstructType2.Phi3 => "phi3",
                InstructType2.Qwen3 => "qwen3",
                InstructType2.Qwq => "qwq",
                InstructType2.Rwkv => "rwkv",
                InstructType2.Vicuna => "vicuna",
                InstructType2.Zephyr => "zephyr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructType2? ToEnum(string value)
        {
            return value switch
            {
                "airoboros" => InstructType2.Airoboros,
                "alpaca" => InstructType2.Alpaca,
                "alpaca-modif" => InstructType2.AlpacaModif,
                "chatml" => InstructType2.Chatml,
                "claude" => InstructType2.Claude,
                "code-llama" => InstructType2.CodeLlama,
                "deepseek-r1" => InstructType2.DeepseekR1,
                "deepseek-v3.1" => InstructType2.DeepseekV31,
                "gemma" => InstructType2.Gemma,
                "llama2" => InstructType2.Llama2,
                "llama3" => InstructType2.Llama3,
                "mistral" => InstructType2.Mistral,
                "nemotron" => InstructType2.Nemotron,
                "neural" => InstructType2.Neural,
                "none" => InstructType2.None,
                "openchat" => InstructType2.Openchat,
                "phi3" => InstructType2.Phi3,
                "qwen3" => InstructType2.Qwen3,
                "qwq" => InstructType2.Qwq,
                "rwkv" => InstructType2.Rwkv,
                "vicuna" => InstructType2.Vicuna,
                "zephyr" => InstructType2.Zephyr,
                _ => null,
            };
        }
    }
}