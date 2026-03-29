//HintName: G.Models.TransferAssistantModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model provider for the transfer assistant
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferAssistantModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-llm")]
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferAssistantModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferAssistantModelProvider value)
        {
            return value switch
            {
                TransferAssistantModelProvider.Anthropic => "anthropic",
                TransferAssistantModelProvider.CustomLlm => "custom-llm",
                TransferAssistantModelProvider.Google => "google",
                TransferAssistantModelProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferAssistantModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => TransferAssistantModelProvider.Anthropic,
                "custom-llm" => TransferAssistantModelProvider.CustomLlm,
                "google" => TransferAssistantModelProvider.Google,
                "openai" => TransferAssistantModelProvider.Openai,
                _ => null,
            };
        }
    }
}