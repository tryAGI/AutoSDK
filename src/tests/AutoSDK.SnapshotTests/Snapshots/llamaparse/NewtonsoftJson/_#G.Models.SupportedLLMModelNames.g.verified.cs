//HintName: G.Models.SupportedLLMModelNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SupportedLLMModelNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI_GPT_4O")]
        AzureOpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI_GPT_4O_MINI")]
        AzureOpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI_GPT_4_1")]
        AzureOpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI_GPT_4_1_MINI")]
        AzureOpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI_GPT_4_1_NANO")]
        AzureOpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEDROCK_CLAUDE_3_5_SONNET_V1")]
        BedrockClaude35SonnetV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEDROCK_CLAUDE_3_5_SONNET_V2")]
        BedrockClaude35SonnetV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLAUDE_4_5_SONNET")]
        Claude45Sonnet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT_4O")]
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT_4O_MINI")]
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT_4_1")]
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT_4_1_MINI")]
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GPT_4_1_NANO")]
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