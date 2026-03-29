//HintName: G.Models.ApiMlCreateRequestAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auth method
    /// </summary>
    public enum ApiMlCreateRequestAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        BasicAuth,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiMlCreateRequestAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiMlCreateRequestAuthMethod value)
        {
            return value switch
            {
                ApiMlCreateRequestAuthMethod.BasicAuth => "BASIC_AUTH",
                ApiMlCreateRequestAuthMethod.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiMlCreateRequestAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_AUTH" => ApiMlCreateRequestAuthMethod.BasicAuth,
                "NONE" => ApiMlCreateRequestAuthMethod.None,
                _ => null,
            };
        }
    }
}