//HintName: G.Models.CreateToolRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateToolRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambda,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateToolRequestDiscriminatorType.Lambda => "lambda",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "lambda" => CreateToolRequestDiscriminatorType.Lambda,
                _ => null,
            };
        }
    }
}