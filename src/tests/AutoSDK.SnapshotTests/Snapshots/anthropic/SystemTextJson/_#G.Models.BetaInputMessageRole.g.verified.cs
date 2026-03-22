//HintName: G.Models.BetaInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageRole value)
        {
            return value switch
            {
                BetaInputMessageRole.Assistant => "assistant",
                BetaInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaInputMessageRole.Assistant,
                "user" => BetaInputMessageRole.User,
                _ => null,
            };
        }
    }
}