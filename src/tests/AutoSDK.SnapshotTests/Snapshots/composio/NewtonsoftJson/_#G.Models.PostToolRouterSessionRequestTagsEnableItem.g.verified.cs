//HintName: G.Models.PostToolRouterSessionRequestTagsEnableItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionRequestTagsEnableItem
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
    public static class PostToolRouterSessionRequestTagsEnableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTagsEnableItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTagsEnableItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTagsEnableItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTagsEnableItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTagsEnableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTagsEnableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestTagsEnableItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTagsEnableItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTagsEnableItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTagsEnableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}