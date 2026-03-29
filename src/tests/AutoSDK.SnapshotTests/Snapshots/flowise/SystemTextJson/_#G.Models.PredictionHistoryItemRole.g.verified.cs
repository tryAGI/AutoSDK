//HintName: G.Models.PredictionHistoryItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message<br/>
    /// Example: apiMessage
    /// </summary>
    public enum PredictionHistoryItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        ApiMessage,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionHistoryItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionHistoryItemRole value)
        {
            return value switch
            {
                PredictionHistoryItemRole.ApiMessage => "apiMessage",
                PredictionHistoryItemRole.UserMessage => "userMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionHistoryItemRole? ToEnum(string value)
        {
            return value switch
            {
                "apiMessage" => PredictionHistoryItemRole.ApiMessage,
                "userMessage" => PredictionHistoryItemRole.UserMessage,
                _ => null,
            };
        }
    }
}