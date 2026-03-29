//HintName: G.Models.CreateComputerToolDTOName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'computer'<br/>
    /// Default Value: computer
    /// </summary>
    public enum CreateComputerToolDTOName
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputerToolDTONameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputerToolDTOName value)
        {
            return value switch
            {
                CreateComputerToolDTOName.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputerToolDTOName? ToEnum(string value)
        {
            return value switch
            {
                "computer" => CreateComputerToolDTOName.Computer,
                _ => null,
            };
        }
    }
}