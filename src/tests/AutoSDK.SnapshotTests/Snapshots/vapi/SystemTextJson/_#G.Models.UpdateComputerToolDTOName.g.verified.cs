//HintName: G.Models.UpdateComputerToolDTOName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'computer'<br/>
    /// Default Value: computer
    /// </summary>
    public enum UpdateComputerToolDTOName
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateComputerToolDTONameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateComputerToolDTOName value)
        {
            return value switch
            {
                UpdateComputerToolDTOName.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateComputerToolDTOName? ToEnum(string value)
        {
            return value switch
            {
                "computer" => UpdateComputerToolDTOName.Computer,
                _ => null,
            };
        }
    }
}