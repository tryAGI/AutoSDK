//HintName: G.Models.CustomLLMCreateDtoCustomOAuth2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomLLMCreateDtoCustomOAuth2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMCreateDtoCustomOAuth2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMCreateDtoCustomOAuth2Type value)
        {
            return value switch
            {
                CustomLLMCreateDtoCustomOAuth2Type.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMCreateDtoCustomOAuth2Type? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => CustomLLMCreateDtoCustomOAuth2Type.Oauth2,
                _ => null,
            };
        }
    }
}