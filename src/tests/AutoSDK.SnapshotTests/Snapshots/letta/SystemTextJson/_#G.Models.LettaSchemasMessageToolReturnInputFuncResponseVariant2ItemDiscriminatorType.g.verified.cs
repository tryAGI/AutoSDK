//HintName: G.Models.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Image => "image",
                LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Image,
                "text" => LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}