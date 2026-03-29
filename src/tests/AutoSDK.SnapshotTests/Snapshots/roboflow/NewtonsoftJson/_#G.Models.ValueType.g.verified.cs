//HintName: G.Models.ValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dict")]
        Dict,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueType value)
        {
            return value switch
            {
                ValueType.Any => "any",
                ValueType.Boolean => "boolean",
                ValueType.Dict => "dict",
                ValueType.Float => "float",
                ValueType.Integer => "integer",
                ValueType.List => "list",
                ValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueType? ToEnum(string value)
        {
            return value switch
            {
                "any" => ValueType.Any,
                "boolean" => ValueType.Boolean,
                "dict" => ValueType.Dict,
                "float" => ValueType.Float,
                "integer" => ValueType.Integer,
                "list" => ValueType.List,
                "string" => ValueType.String,
                _ => null,
            };
        }
    }
}