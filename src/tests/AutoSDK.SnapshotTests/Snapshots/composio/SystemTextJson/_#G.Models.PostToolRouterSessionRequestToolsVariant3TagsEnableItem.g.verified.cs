//HintName: G.Models.PostToolRouterSessionRequestToolsVariant3TagsEnableItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolRouterSessionRequestToolsVariant3TagsEnableItem
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
    public static class PostToolRouterSessionRequestToolsVariant3TagsEnableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestToolsVariant3TagsEnableItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestToolsVariant3TagsEnableItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestToolsVariant3TagsEnableItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestToolsVariant3TagsEnableItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestToolsVariant3TagsEnableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestToolsVariant3TagsEnableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestToolsVariant3TagsEnableItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestToolsVariant3TagsEnableItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestToolsVariant3TagsEnableItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestToolsVariant3TagsEnableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}