//HintName: G.Models.TypeType1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a type action, this property is <br/>
    /// always set to `type`.<br/>
    /// Default Value: type
    /// </summary>
    public enum TypeType1
    {
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeType1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeType1 value)
        {
            return value switch
            {
                TypeType1.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeType1? ToEnum(string value)
        {
            return value switch
            {
                "type" => TypeType1.Type,
                _ => null,
            };
        }
    }
}