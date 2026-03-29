//HintName: G.Models.ComputerToolName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'computer'<br/>
    /// Default Value: computer
    /// </summary>
    public enum ComputerToolName
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolName value)
        {
            return value switch
            {
                ComputerToolName.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolName? ToEnum(string value)
        {
            return value switch
            {
                "computer" => ComputerToolName.Computer,
                _ => null,
            };
        }
    }
}