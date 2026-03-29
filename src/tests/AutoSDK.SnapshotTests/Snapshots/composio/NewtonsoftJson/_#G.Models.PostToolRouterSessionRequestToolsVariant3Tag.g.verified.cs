//HintName: G.Models.PostToolRouterSessionRequestToolsVariant3Tag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionRequestToolsVariant3Tag
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
    public static class PostToolRouterSessionRequestToolsVariant3TagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestToolsVariant3Tag value)
        {
            return value switch
            {
                PostToolRouterSessionRequestToolsVariant3Tag.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestToolsVariant3Tag.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestToolsVariant3Tag.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestToolsVariant3Tag.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestToolsVariant3Tag? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestToolsVariant3Tag.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestToolsVariant3Tag.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestToolsVariant3Tag.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestToolsVariant3Tag.ReadOnlyHint,
                _ => null,
            };
        }
    }
}