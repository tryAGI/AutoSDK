//HintName: G.Models.CreateExpressiveRequestDtoBackgroundVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveRequestDtoBackgroundVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Color,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoBackgroundVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoBackgroundVariant1Type value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoBackgroundVariant1Type.Color => "color",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoBackgroundVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "color" => CreateExpressiveRequestDtoBackgroundVariant1Type.Color,
                _ => null,
            };
        }
    }
}