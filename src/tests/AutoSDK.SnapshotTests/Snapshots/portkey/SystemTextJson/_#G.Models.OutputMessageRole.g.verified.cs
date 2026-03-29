//HintName: G.Models.OutputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the output message. Always `assistant`.
    /// </summary>
    public enum OutputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageRole value)
        {
            return value switch
            {
                OutputMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OutputMessageRole.Assistant,
                _ => null,
            };
        }
    }
}