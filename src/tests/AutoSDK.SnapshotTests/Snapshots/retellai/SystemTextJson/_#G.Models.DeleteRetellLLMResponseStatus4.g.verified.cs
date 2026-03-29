//HintName: G.Models.DeleteRetellLLMResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteRetellLLMResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteRetellLLMResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRetellLLMResponseStatus4 value)
        {
            return value switch
            {
                DeleteRetellLLMResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRetellLLMResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteRetellLLMResponseStatus4.Error,
                _ => null,
            };
        }
    }
}