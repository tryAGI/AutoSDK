//HintName: G.Models.OutputToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "output" for Output tool.
    /// </summary>
    public enum OutputToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputToolType value)
        {
            return value switch
            {
                OutputToolType.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputToolType? ToEnum(string value)
        {
            return value switch
            {
                "output" => OutputToolType.Output,
                _ => null,
            };
        }
    }
}