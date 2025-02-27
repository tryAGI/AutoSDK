//HintName: G.Models.BetaComputerUseTool20250124Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaComputerUseTool20250124Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_20250124")]
        Computer20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerUseTool20250124TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUseTool20250124Type value)
        {
            return value switch
            {
                BetaComputerUseTool20250124Type.Computer20250124 => "computer_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUseTool20250124Type? ToEnum(string value)
        {
            return value switch
            {
                "computer_20250124" => BetaComputerUseTool20250124Type.Computer20250124,
                _ => null,
            };
        }
    }
}