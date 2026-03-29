//HintName: G.Models.ComputerToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the computer call. Always `computer_call`.<br/>
    /// Default Value: computer_call
    /// </summary>
    public enum ComputerToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolCallType value)
        {
            return value switch
            {
                ComputerToolCallType.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => ComputerToolCallType.ComputerCall,
                _ => null,
            };
        }
    }
}