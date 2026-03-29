//HintName: G.Models.PostToolRouterSessionRequestTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionRequestTag
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
    public static class PostToolRouterSessionRequestTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTag value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTag.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTag.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTag.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTag.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTag? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestTag.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTag.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTag.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTag.ReadOnlyHint,
                _ => null,
            };
        }
    }
}