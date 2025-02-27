//HintName: G.Models.BetaComputerUseTool20250124Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaComputerUseTool20250124Name
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer")]
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerUseTool20250124NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUseTool20250124Name value)
        {
            return value switch
            {
                BetaComputerUseTool20250124Name.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUseTool20250124Name? ToEnum(string value)
        {
            return value switch
            {
                "computer" => BetaComputerUseTool20250124Name.Computer,
                _ => null,
            };
        }
    }
}