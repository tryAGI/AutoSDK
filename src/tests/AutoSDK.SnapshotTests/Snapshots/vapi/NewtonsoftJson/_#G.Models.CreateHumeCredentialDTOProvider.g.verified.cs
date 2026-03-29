//HintName: G.Models.CreateHumeCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateHumeCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hume")]
        Hume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateHumeCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateHumeCredentialDTOProvider value)
        {
            return value switch
            {
                CreateHumeCredentialDTOProvider.Hume => "hume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateHumeCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "hume" => CreateHumeCredentialDTOProvider.Hume,
                _ => null,
            };
        }
    }
}