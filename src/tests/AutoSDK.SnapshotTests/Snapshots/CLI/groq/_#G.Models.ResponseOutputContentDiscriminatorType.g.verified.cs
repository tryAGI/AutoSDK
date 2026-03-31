//HintName: G.Models.ResponseOutputContentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputContentDiscriminatorType value)
        {
            return value switch
            {
                ResponseOutputContentDiscriminatorType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponseOutputContentDiscriminatorType.OutputText,
                _ => null,
            };
        }
    }
}