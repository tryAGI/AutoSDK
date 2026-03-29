//HintName: G.Models.ComputerToolWithToolCallName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'computer'<br/>
    /// Default Value: computer
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerToolWithToolCallName
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
    public static class ComputerToolWithToolCallNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolWithToolCallName value)
        {
            return value switch
            {
                ComputerToolWithToolCallName.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolWithToolCallName? ToEnum(string value)
        {
            return value switch
            {
                "computer" => ComputerToolWithToolCallName.Computer,
                _ => null,
            };
        }
    }
}