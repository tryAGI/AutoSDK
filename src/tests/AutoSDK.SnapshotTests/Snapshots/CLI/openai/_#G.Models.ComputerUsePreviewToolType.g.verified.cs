//HintName: G.Models.ComputerUsePreviewToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the computer use tool. Always `computer_use_preview`.<br/>
    /// Default Value: computer_use_preview
    /// </summary>
    public enum ComputerUsePreviewToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUsePreviewToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUsePreviewToolType value)
        {
            return value switch
            {
                ComputerUsePreviewToolType.ComputerUsePreview => "computer_use_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUsePreviewToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => ComputerUsePreviewToolType.ComputerUsePreview,
                _ => null,
            };
        }
    }
}