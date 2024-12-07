//HintName: G.Models.BetaComputerUseTool20241022Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    public enum BetaComputerUseTool20241022Name
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerUseTool20241022NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUseTool20241022Name value)
        {
            return value switch
            {
                BetaComputerUseTool20241022Name.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUseTool20241022Name? ToEnum(string value)
        {
            return value switch
            {
                "computer" => BetaComputerUseTool20241022Name.Computer,
                _ => null,
            };
        }
    }
}