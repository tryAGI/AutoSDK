//HintName: G.Models.PostToolRouterSessionResponseConfigTagsDisabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolRouterSessionResponseConfigTagsDisabledItem
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
    public static class PostToolRouterSessionResponseConfigTagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigTagsDisabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigTagsDisabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigTagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}