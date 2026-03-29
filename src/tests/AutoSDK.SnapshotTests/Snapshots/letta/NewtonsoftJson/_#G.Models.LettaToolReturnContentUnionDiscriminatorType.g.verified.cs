//HintName: G.Models.LettaToolReturnContentUnionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaToolReturnContentUnionDiscriminatorType
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
    public static class LettaToolReturnContentUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaToolReturnContentUnionDiscriminatorType value)
        {
            return value switch
            {
                LettaToolReturnContentUnionDiscriminatorType.Image => "image",
                LettaToolReturnContentUnionDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaToolReturnContentUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaToolReturnContentUnionDiscriminatorType.Image,
                "text" => LettaToolReturnContentUnionDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}