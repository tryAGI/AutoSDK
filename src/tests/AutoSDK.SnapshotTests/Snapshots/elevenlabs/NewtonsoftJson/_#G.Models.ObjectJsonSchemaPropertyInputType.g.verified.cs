//HintName: G.Models.ObjectJsonSchemaPropertyInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectJsonSchemaPropertyInputType
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
    public static class ObjectJsonSchemaPropertyInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectJsonSchemaPropertyInputType value)
        {
            return value switch
            {
                ObjectJsonSchemaPropertyInputType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectJsonSchemaPropertyInputType? ToEnum(string value)
        {
            return value switch
            {
                "object" => ObjectJsonSchemaPropertyInputType.Object,
                _ => null,
            };
        }
    }
}