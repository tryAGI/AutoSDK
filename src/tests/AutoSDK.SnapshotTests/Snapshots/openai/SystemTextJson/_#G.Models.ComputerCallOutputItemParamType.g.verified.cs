//HintName: G.Models.ComputerCallOutputItemParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the computer tool call output. Always `computer_call_output`.<br/>
    /// Default Value: computer_call_output
    /// </summary>
    public enum ComputerCallOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerCallOutputItemParamType value)
        {
            return value switch
            {
                ComputerCallOutputItemParamType.ComputerCallOutput => "computer_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output" => ComputerCallOutputItemParamType.ComputerCallOutput,
                _ => null,
            };
        }
    }
}