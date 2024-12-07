//HintName: G.Models.AnthropicBetaEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBetaEnum
    {
        /// <summary>
        /// 
        /// </summary>
        MessageBatches20240924,
        /// <summary>
        /// 
        /// </summary>
        PromptCaching20240731,
        /// <summary>
        /// 
        /// </summary>
        ComputerUse20241022,
        /// <summary>
        /// 
        /// </summary>
        Pdfs20240925,
        /// <summary>
        /// 
        /// </summary>
        TokenCounting20241101,
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
                AnthropicBetaEnum.Pdfs20240925 => "pdfs-2024-09-25",
                AnthropicBetaEnum.TokenCounting20241101 => "token-counting-2024-11-01",
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
                "pdfs-2024-09-25" => AnthropicBetaEnum.Pdfs20240925,
                "token-counting-2024-11-01" => AnthropicBetaEnum.TokenCounting20241101,
                _ => null,
            };
        }
    }
}