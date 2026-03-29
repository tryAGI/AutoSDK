//HintName: G.Models.VariableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VariableType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="KVVariable")]
        KVVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ListVariable")]
        ListVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VariableType value)
        {
            return value switch
            {
                VariableType.KVVariable => "KVVariable",
                VariableType.ListVariable => "ListVariable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VariableType? ToEnum(string value)
        {
            return value switch
            {
                "KVVariable" => VariableType.KVVariable,
                "ListVariable" => VariableType.ListVariable,
                _ => null,
            };
        }
    }
}