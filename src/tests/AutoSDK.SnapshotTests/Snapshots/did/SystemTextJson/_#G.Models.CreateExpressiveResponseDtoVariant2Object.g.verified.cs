//HintName: G.Models.CreateExpressiveResponseDtoVariant2Object.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveResponseDtoVariant2Object
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveResponseDtoVariant2ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveResponseDtoVariant2Object value)
        {
            return value switch
            {
                CreateExpressiveResponseDtoVariant2Object.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveResponseDtoVariant2Object? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => CreateExpressiveResponseDtoVariant2Object.Expressive,
                _ => null,
            };
        }
    }
}