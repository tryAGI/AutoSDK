//HintName: G.Models.CreateOpenRouterCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateOpenRouterCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter")]
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOpenRouterCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOpenRouterCredentialDTOProvider value)
        {
            return value switch
            {
                CreateOpenRouterCredentialDTOProvider.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOpenRouterCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => CreateOpenRouterCredentialDTOProvider.Openrouter,
                _ => null,
            };
        }
    }
}