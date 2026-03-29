//HintName: G.Models.CreateComputerToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "computer" for Computer tool.
    /// </summary>
    public enum CreateComputerToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputerToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputerToolDTOType value)
        {
            return value switch
            {
                CreateComputerToolDTOType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputerToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => CreateComputerToolDTOType.Computer,
                _ => null,
            };
        }
    }
}