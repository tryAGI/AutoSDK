//HintName: G.Models.UpdateAgentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAgentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAgentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentResponseStatus value)
        {
            return value switch
            {
                UpdateAgentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateAgentResponseStatus.Error,
                _ => null,
            };
        }
    }
}