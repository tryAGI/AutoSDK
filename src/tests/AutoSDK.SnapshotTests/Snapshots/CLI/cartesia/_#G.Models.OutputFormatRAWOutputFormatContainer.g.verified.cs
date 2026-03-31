//HintName: G.Models.OutputFormatRAWOutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormatRAWOutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatRAWOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatRAWOutputFormatContainer value)
        {
            return value switch
            {
                OutputFormatRAWOutputFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatRAWOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => OutputFormatRAWOutputFormatContainer.Raw,
                _ => null,
            };
        }
    }
}