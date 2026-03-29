//HintName: G.Models.CreateDeepInfraCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDeepInfraCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeepInfraCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeepInfraCredentialDTOProvider value)
        {
            return value switch
            {
                CreateDeepInfraCredentialDTOProvider.Deepinfra => "deepinfra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeepInfraCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra" => CreateDeepInfraCredentialDTOProvider.Deepinfra,
                _ => null,
            };
        }
    }
}