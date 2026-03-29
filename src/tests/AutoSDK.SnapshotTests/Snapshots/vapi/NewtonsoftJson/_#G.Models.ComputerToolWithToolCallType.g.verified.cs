//HintName: G.Models.ComputerToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "computer" for Computer tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerToolWithToolCallType
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
    public static class ComputerToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolWithToolCallType value)
        {
            return value switch
            {
                ComputerToolWithToolCallType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => ComputerToolWithToolCallType.Computer,
                _ => null,
            };
        }
    }
}