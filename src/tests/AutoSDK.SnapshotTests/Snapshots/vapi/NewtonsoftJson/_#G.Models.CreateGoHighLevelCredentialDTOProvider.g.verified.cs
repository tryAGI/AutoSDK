//HintName: G.Models.CreateGoHighLevelCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoHighLevelCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel")]
        Gohighlevel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoHighLevelCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGoHighLevelCredentialDTOProvider.Gohighlevel => "gohighlevel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel" => CreateGoHighLevelCredentialDTOProvider.Gohighlevel,
                _ => null,
            };
        }
    }
}