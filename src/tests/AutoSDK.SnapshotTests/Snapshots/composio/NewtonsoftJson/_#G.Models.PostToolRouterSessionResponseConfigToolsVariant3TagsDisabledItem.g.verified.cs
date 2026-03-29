//HintName: G.Models.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem
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
    public static class PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}