//HintName: G.Models.PostToolRouterSessionResponseConfigTagsEnabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionResponseConfigTagsEnabledItem
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
    public static class PostToolRouterSessionResponseConfigTagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigTagsEnabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigTagsEnabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigTagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}