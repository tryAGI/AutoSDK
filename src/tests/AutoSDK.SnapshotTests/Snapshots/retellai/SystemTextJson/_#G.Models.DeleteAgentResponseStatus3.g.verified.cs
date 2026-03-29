//HintName: G.Models.DeleteAgentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAgentResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAgentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAgentResponseStatus3 value)
        {
            return value switch
            {
                DeleteAgentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAgentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteAgentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}