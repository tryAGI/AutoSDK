//HintName: G.Models.AuthMethodEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `NONE` - None<br/>
    /// * `BASIC_AUTH` - Basic Auth
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthMethodEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC_AUTH")]
        BasicAuth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthMethodEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthMethodEnum value)
        {
            return value switch
            {
                AuthMethodEnum.BasicAuth => "BASIC_AUTH",
                AuthMethodEnum.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthMethodEnum? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_AUTH" => AuthMethodEnum.BasicAuth,
                "NONE" => AuthMethodEnum.None,
                _ => null,
            };
        }
    }
}