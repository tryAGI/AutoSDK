//HintName: G.Models.VoicesProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicesProvider
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
    public static class VoicesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesProvider value)
        {
            return value switch
            {
                VoicesProvider.Amazon => "amazon",
                VoicesProvider.AzureOpenai => "azure-openai",
                VoicesProvider.Elevenlabs => "elevenlabs",
                VoicesProvider.Google => "google",
                VoicesProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesProvider? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => VoicesProvider.Amazon,
                "azure-openai" => VoicesProvider.AzureOpenai,
                "elevenlabs" => VoicesProvider.Elevenlabs,
                "google" => VoicesProvider.Google,
                "microsoft" => VoicesProvider.Microsoft,
                _ => null,
            };
        }
    }
}