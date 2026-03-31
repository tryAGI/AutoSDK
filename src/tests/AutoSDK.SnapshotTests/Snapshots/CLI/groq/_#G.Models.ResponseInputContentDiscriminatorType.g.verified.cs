//HintName: G.Models.ResponseInputContentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInputContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputContentDiscriminatorType value)
        {
            return value switch
            {
                ResponseInputContentDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => ResponseInputContentDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}