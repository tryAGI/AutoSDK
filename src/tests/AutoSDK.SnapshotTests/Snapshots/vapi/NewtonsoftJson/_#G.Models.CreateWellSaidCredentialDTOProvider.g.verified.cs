//HintName: G.Models.CreateWellSaidCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWellSaidCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wellsaid")]
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWellSaidCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWellSaidCredentialDTOProvider value)
        {
            return value switch
            {
                CreateWellSaidCredentialDTOProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWellSaidCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "wellsaid" => CreateWellSaidCredentialDTOProvider.Wellsaid,
                _ => null,
            };
        }
    }
}