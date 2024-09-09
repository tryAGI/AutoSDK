//HintName: G.Models.ConnectorAuthStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The OAuth status for the user making the request. One of ["valid", "expired", ""]. Empty string (field is omitted) means the user has not authorized the connector yet.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConnectorAuthStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valid")]
        Valid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorAuthStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorAuthStatus value)
        {
            return value switch
            {
                ConnectorAuthStatus.Valid => "valid",
                ConnectorAuthStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorAuthStatus? ToEnum(string value)
        {
            return value switch
            {
                "valid" => ConnectorAuthStatus.Valid,
                "expired" => ConnectorAuthStatus.Expired,
                _ => null,
            };
        }
    }
}