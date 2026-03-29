//HintName: G.Models.CreateRetellLLMResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRetellLLMResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRetellLLMResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRetellLLMResponseStatus value)
        {
            return value switch
            {
                CreateRetellLLMResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRetellLLMResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateRetellLLMResponseStatus.Error,
                _ => null,
            };
        }
    }
}