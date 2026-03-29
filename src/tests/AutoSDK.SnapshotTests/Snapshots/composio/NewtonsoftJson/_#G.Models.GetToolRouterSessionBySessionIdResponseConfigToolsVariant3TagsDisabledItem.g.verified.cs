//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="destructiveHint")]
        DestructiveHint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="idempotentHint")]
        IdempotentHint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openWorldHint")]
        OpenWorldHint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="readOnlyHint")]
        ReadOnlyHint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}