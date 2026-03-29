//HintName: G.Models.PostToolRouterSessionRequestTagsDisableItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionRequestTagsDisableItem
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
    public static class PostToolRouterSessionRequestTagsDisableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTagsDisableItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTagsDisableItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTagsDisableItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTagsDisableItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTagsDisableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTagsDisableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestTagsDisableItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTagsDisableItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTagsDisableItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTagsDisableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}