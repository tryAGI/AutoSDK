//HintName: G.Models.BetaInputSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaInputSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputSchemaType value)
        {
            return value switch
            {
                BetaInputSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => BetaInputSchemaType.Object,
                _ => null,
            };
        }
    }
}