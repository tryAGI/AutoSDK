//HintName: G.Models.CreateNeuphonicCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateNeuphonicCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neuphonic")]
        Neuphonic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateNeuphonicCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateNeuphonicCredentialDTOProvider value)
        {
            return value switch
            {
                CreateNeuphonicCredentialDTOProvider.Neuphonic => "neuphonic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateNeuphonicCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "neuphonic" => CreateNeuphonicCredentialDTOProvider.Neuphonic,
                _ => null,
            };
        }
    }
}