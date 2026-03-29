//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem
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
    public static class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}