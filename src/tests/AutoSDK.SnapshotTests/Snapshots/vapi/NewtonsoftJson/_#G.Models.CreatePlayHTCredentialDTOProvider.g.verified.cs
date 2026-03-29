//HintName: G.Models.CreatePlayHTCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreatePlayHTCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playht")]
        Playht,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePlayHTCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePlayHTCredentialDTOProvider value)
        {
            return value switch
            {
                CreatePlayHTCredentialDTOProvider.Playht => "playht",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePlayHTCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "playht" => CreatePlayHTCredentialDTOProvider.Playht,
                _ => null,
            };
        }
    }
}