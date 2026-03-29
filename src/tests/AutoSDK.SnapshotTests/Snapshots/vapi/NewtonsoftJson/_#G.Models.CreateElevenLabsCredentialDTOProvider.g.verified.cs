//HintName: G.Models.CreateElevenLabsCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateElevenLabsCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="11labs")]
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateElevenLabsCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateElevenLabsCredentialDTOProvider value)
        {
            return value switch
            {
                CreateElevenLabsCredentialDTOProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateElevenLabsCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => CreateElevenLabsCredentialDTOProvider.x11labs,
                _ => null,
            };
        }
    }
}