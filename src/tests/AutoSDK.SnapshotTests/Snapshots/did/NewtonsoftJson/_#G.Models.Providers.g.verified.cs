//HintName: G.Models.Providers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Providers
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
    public static class ProvidersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Providers value)
        {
            return value switch
            {
                Providers.Amazon => "amazon",
                Providers.AzureOpenai => "azure-openai",
                Providers.Elevenlabs => "elevenlabs",
                Providers.Google => "google",
                Providers.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Providers? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => Providers.Amazon,
                "azure-openai" => Providers.AzureOpenai,
                "elevenlabs" => Providers.Elevenlabs,
                "google" => Providers.Google,
                "microsoft" => Providers.Microsoft,
                _ => null,
            };
        }
    }
}