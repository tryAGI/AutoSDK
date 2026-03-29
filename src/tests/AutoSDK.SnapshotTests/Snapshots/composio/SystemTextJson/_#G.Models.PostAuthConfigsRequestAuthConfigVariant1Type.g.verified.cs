//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostAuthConfigsRequestAuthConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        UseComposioManagedAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostAuthConfigsRequestAuthConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostAuthConfigsRequestAuthConfigVariant1Type value)
        {
            return value switch
            {
                PostAuthConfigsRequestAuthConfigVariant1Type.UseComposioManagedAuth => "use_composio_managed_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostAuthConfigsRequestAuthConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "use_composio_managed_auth" => PostAuthConfigsRequestAuthConfigVariant1Type.UseComposioManagedAuth,
                _ => null,
            };
        }
    }
}