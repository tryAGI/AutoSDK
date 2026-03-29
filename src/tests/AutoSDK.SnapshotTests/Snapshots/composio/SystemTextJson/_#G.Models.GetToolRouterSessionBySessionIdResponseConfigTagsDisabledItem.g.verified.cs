//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem
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
    public static class GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}