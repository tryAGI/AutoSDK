//HintName: G.Models.SupportedLLMModelNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupportedLLMModelNames
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        BedrockClaude35SonnetV1,
        /// <summary>
        /// 
        /// </summary>
        BedrockClaude35SonnetV2,
        /// <summary>
        /// 
        /// </summary>
        Claude45Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLLMModelNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLLMModelNames value)
        {
            return value switch
            {
                SupportedLLMModelNames.AzureOpenaiGpt4o => "AZURE_OPENAI_GPT_4O",
                SupportedLLMModelNames.AzureOpenaiGpt4oMini => "AZURE_OPENAI_GPT_4O_MINI",
                SupportedLLMModelNames.AzureOpenaiGpt41 => "AZURE_OPENAI_GPT_4_1",
                SupportedLLMModelNames.AzureOpenaiGpt41Mini => "AZURE_OPENAI_GPT_4_1_MINI",
                SupportedLLMModelNames.AzureOpenaiGpt41Nano => "AZURE_OPENAI_GPT_4_1_NANO",
                SupportedLLMModelNames.BedrockClaude35SonnetV1 => "BEDROCK_CLAUDE_3_5_SONNET_V1",
                SupportedLLMModelNames.BedrockClaude35SonnetV2 => "BEDROCK_CLAUDE_3_5_SONNET_V2",
                SupportedLLMModelNames.Claude45Sonnet => "CLAUDE_4_5_SONNET",
                SupportedLLMModelNames.Gpt4o => "GPT_4O",
                SupportedLLMModelNames.Gpt4oMini => "GPT_4O_MINI",
                SupportedLLMModelNames.Gpt41 => "GPT_4_1",
                SupportedLLMModelNames.Gpt41Mini => "GPT_4_1_MINI",
                SupportedLLMModelNames.Gpt41Nano => "GPT_4_1_NANO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLLMModelNames? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_OPENAI_GPT_4O" => SupportedLLMModelNames.AzureOpenaiGpt4o,
                "AZURE_OPENAI_GPT_4O_MINI" => SupportedLLMModelNames.AzureOpenaiGpt4oMini,
                "AZURE_OPENAI_GPT_4_1" => SupportedLLMModelNames.AzureOpenaiGpt41,
                "AZURE_OPENAI_GPT_4_1_MINI" => SupportedLLMModelNames.AzureOpenaiGpt41Mini,
                "AZURE_OPENAI_GPT_4_1_NANO" => SupportedLLMModelNames.AzureOpenaiGpt41Nano,
                "BEDROCK_CLAUDE_3_5_SONNET_V1" => SupportedLLMModelNames.BedrockClaude35SonnetV1,
                "BEDROCK_CLAUDE_3_5_SONNET_V2" => SupportedLLMModelNames.BedrockClaude35SonnetV2,
                "CLAUDE_4_5_SONNET" => SupportedLLMModelNames.Claude45Sonnet,
                "GPT_4O" => SupportedLLMModelNames.Gpt4o,
                "GPT_4O_MINI" => SupportedLLMModelNames.Gpt4oMini,
                "GPT_4_1" => SupportedLLMModelNames.Gpt41,
                "GPT_4_1_MINI" => SupportedLLMModelNames.Gpt41Mini,
                "GPT_4_1_NANO" => SupportedLLMModelNames.Gpt41Nano,
                _ => null,
            };
        }
    }
}