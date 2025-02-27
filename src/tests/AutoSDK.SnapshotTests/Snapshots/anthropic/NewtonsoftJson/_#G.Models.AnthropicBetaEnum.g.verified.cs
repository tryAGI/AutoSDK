//HintName: G.Models.AnthropicBetaEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicBetaEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message-batches-2024-09-24")]
        MessageBatches20240924,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt-caching-2024-07-31")]
        PromptCaching20240731,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer-use-2024-10-22")]
        ComputerUse20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer-use-2025-01-24")]
        ComputerUse20250124,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdfs-2024-09-25")]
        Pdfs20240925,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="token-counting-2024-11-01")]
        TokenCounting20241101,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="token-efficient-tools-2025-02-19")]
        TokenEfficientTools20250219,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output-128k-2025-02-19")]
        Output128k20250219,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBetaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBetaEnum value)
        {
            return value switch
            {
                AnthropicBetaEnum.MessageBatches20240924 => "message-batches-2024-09-24",
                AnthropicBetaEnum.PromptCaching20240731 => "prompt-caching-2024-07-31",
                AnthropicBetaEnum.ComputerUse20241022 => "computer-use-2024-10-22",
                AnthropicBetaEnum.ComputerUse20250124 => "computer-use-2025-01-24",
                AnthropicBetaEnum.Pdfs20240925 => "pdfs-2024-09-25",
                AnthropicBetaEnum.TokenCounting20241101 => "token-counting-2024-11-01",
                AnthropicBetaEnum.TokenEfficientTools20250219 => "token-efficient-tools-2025-02-19",
                AnthropicBetaEnum.Output128k20250219 => "output-128k-2025-02-19",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBetaEnum? ToEnum(string value)
        {
            return value switch
            {
                "message-batches-2024-09-24" => AnthropicBetaEnum.MessageBatches20240924,
                "prompt-caching-2024-07-31" => AnthropicBetaEnum.PromptCaching20240731,
                "computer-use-2024-10-22" => AnthropicBetaEnum.ComputerUse20241022,
                "computer-use-2025-01-24" => AnthropicBetaEnum.ComputerUse20250124,
                "pdfs-2024-09-25" => AnthropicBetaEnum.Pdfs20240925,
                "token-counting-2024-11-01" => AnthropicBetaEnum.TokenCounting20241101,
                "token-efficient-tools-2025-02-19" => AnthropicBetaEnum.TokenEfficientTools20250219,
                "output-128k-2025-02-19" => AnthropicBetaEnum.Output128k20250219,
                _ => null,
            };
        }
    }
}