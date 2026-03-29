//HintName: G.Models.PostToolRouterSessionRequestTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolRouterSessionRequestTag
    {
        /// <summary>
        /// 
        /// </summary>
        DestructiveHint,
        /// <summary>
        /// 
        /// </summary>
        IdempotentHint,
        /// <summary>
        /// 
        /// </summary>
        OpenWorldHint,
        /// <summary>
        /// 
        /// </summary>
        ReadOnlyHint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTag value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTag.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTag.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTag.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTag.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTag? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestTag.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTag.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTag.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTag.ReadOnlyHint,
                _ => null,
            };
        }
    }
}