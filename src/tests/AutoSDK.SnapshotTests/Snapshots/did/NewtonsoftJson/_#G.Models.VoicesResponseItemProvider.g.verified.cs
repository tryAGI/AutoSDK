//HintName: G.Models.VoicesResponseItemProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicesResponseItemProvider
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
    public static class VoicesResponseItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesResponseItemProvider value)
        {
            return value switch
            {
                VoicesResponseItemProvider.Amazon => "amazon",
                VoicesResponseItemProvider.AzureOpenai => "azure-openai",
                VoicesResponseItemProvider.Elevenlabs => "elevenlabs",
                VoicesResponseItemProvider.Google => "google",
                VoicesResponseItemProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesResponseItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => VoicesResponseItemProvider.Amazon,
                "azure-openai" => VoicesResponseItemProvider.AzureOpenai,
                "elevenlabs" => VoicesResponseItemProvider.Elevenlabs,
                "google" => VoicesResponseItemProvider.Google,
                "microsoft" => VoicesResponseItemProvider.Microsoft,
                _ => null,
            };
        }
    }
}