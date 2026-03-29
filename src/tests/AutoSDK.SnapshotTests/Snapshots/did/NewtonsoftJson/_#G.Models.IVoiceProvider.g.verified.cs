//HintName: G.Models.IVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IVoiceProvider value)
        {
            return value switch
            {
                IVoiceProvider.Amazon => "amazon",
                IVoiceProvider.AzureOpenai => "azure-openai",
                IVoiceProvider.Elevenlabs => "elevenlabs",
                IVoiceProvider.Google => "google",
                IVoiceProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => IVoiceProvider.Amazon,
                "azure-openai" => IVoiceProvider.AzureOpenai,
                "elevenlabs" => IVoiceProvider.Elevenlabs,
                "google" => IVoiceProvider.Google,
                "microsoft" => IVoiceProvider.Microsoft,
                _ => null,
            };
        }
    }
}