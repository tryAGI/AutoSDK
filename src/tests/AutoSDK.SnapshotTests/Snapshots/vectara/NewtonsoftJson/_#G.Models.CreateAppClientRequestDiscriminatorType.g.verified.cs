//HintName: G.Models.CreateAppClientRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAppClientRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client_credentials")]
        ClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAppClientRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAppClientRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateAppClientRequestDiscriminatorType.ClientCredentials => "client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAppClientRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_credentials" => CreateAppClientRequestDiscriminatorType.ClientCredentials,
                _ => null,
            };
        }
    }
}