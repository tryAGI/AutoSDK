//HintName: G.Models.ComputerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "computer" for Computer tool.
    /// </summary>
    public enum ComputerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolType value)
        {
            return value switch
            {
                ComputerToolType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => ComputerToolType.Computer,
                _ => null,
            };
        }
    }
}