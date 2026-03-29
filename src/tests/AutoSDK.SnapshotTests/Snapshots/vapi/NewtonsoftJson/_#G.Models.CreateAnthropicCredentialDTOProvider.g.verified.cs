//HintName: G.Models.CreateAnthropicCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnthropicCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnthropicCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnthropicCredentialDTOProvider value)
        {
            return value switch
            {
                CreateAnthropicCredentialDTOProvider.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnthropicCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateAnthropicCredentialDTOProvider.Anthropic,
                _ => null,
            };
        }
    }
}