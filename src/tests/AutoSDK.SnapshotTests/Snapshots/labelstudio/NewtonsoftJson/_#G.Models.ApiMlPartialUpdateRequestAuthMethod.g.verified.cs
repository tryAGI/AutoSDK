//HintName: G.Models.ApiMlPartialUpdateRequestAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auth method
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiMlPartialUpdateRequestAuthMethod
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
    public static class ApiMlPartialUpdateRequestAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiMlPartialUpdateRequestAuthMethod value)
        {
            return value switch
            {
                ApiMlPartialUpdateRequestAuthMethod.BasicAuth => "BASIC_AUTH",
                ApiMlPartialUpdateRequestAuthMethod.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiMlPartialUpdateRequestAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_AUTH" => ApiMlPartialUpdateRequestAuthMethod.BasicAuth,
                "NONE" => ApiMlPartialUpdateRequestAuthMethod.None,
                _ => null,
            };
        }
    }
}