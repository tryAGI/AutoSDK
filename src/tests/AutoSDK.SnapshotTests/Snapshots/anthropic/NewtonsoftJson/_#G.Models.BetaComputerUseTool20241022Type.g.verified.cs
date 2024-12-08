//HintName: G.Models.BetaComputerUseTool20241022Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaComputerUseTool20241022Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_20241022")]
        Computer20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerUseTool20241022TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUseTool20241022Type value)
        {
            return value switch
            {
                BetaComputerUseTool20241022Type.Computer20241022 => "computer_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUseTool20241022Type? ToEnum(string value)
        {
            return value switch
            {
                "computer_20241022" => BetaComputerUseTool20241022Type.Computer20241022,
                _ => null,
            };
        }
    }
}