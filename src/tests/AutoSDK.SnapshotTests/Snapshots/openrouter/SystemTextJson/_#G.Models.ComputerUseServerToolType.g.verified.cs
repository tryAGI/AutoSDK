//HintName: G.Models.ComputerUseServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerUseServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseServerToolType value)
        {
            return value switch
            {
                ComputerUseServerToolType.ComputerUsePreview => "computer_use_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => ComputerUseServerToolType.ComputerUsePreview,
                _ => null,
            };
        }
    }
}