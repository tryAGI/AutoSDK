//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When "required", the agent must specify which account to use. Present only when multiple accounts exist.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection
    {
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? ToEnum(string value)
        {
            return value switch
            {
                "required" => PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection.Required,
                _ => null,
            };
        }
    }
}