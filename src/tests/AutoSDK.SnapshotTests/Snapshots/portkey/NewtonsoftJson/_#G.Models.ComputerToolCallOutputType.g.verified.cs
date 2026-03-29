//HintName: G.Models.ComputerToolCallOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the computer tool call output. Always `computer_call_output`.<br/>
    /// Default Value: computer_call_output
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_call_output")]
        ComputerCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolCallOutputType value)
        {
            return value switch
            {
                ComputerToolCallOutputType.ComputerCallOutput => "computer_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output" => ComputerToolCallOutputType.ComputerCallOutput,
                _ => null,
            };
        }
    }
}