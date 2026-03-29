//HintName: G.Models.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem
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
    public static class PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}