//HintName: G.Models.ComputerToolSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerToolSubType
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
    public static class ComputerToolSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolSubType value)
        {
            return value switch
            {
                ComputerToolSubType.Computer20241022 => "computer_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolSubType? ToEnum(string value)
        {
            return value switch
            {
                "computer_20241022" => ComputerToolSubType.Computer20241022,
                _ => null,
            };
        }
    }
}