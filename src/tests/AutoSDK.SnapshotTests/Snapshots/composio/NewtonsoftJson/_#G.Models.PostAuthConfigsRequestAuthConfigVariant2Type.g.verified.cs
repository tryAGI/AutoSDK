//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostAuthConfigsRequestAuthConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_custom_auth")]
        UseCustomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostAuthConfigsRequestAuthConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostAuthConfigsRequestAuthConfigVariant2Type value)
        {
            return value switch
            {
                PostAuthConfigsRequestAuthConfigVariant2Type.UseCustomAuth => "use_custom_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostAuthConfigsRequestAuthConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "use_custom_auth" => PostAuthConfigsRequestAuthConfigVariant2Type.UseCustomAuth,
                _ => null,
            };
        }
    }
}