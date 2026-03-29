//HintName: G.Models.UpdateRetellLLMResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRetellLLMResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRetellLLMResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRetellLLMResponseStatus value)
        {
            return value switch
            {
                UpdateRetellLLMResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRetellLLMResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateRetellLLMResponseStatus.Error,
                _ => null,
            };
        }
    }
}