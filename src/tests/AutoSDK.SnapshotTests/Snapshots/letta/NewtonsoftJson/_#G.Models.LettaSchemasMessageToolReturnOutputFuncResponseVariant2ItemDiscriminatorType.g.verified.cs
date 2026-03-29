//HintName: G.Models.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Image => "image",
                LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Image,
                "text" => LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}