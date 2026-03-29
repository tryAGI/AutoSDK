//HintName: G.Models.StructuredFilterGroupLogic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to combine the filters in this group.<br/>
    /// Default Value: AND
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StructuredFilterGroupLogic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AND")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OR")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredFilterGroupLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredFilterGroupLogic value)
        {
            return value switch
            {
                StructuredFilterGroupLogic.And => "AND",
                StructuredFilterGroupLogic.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredFilterGroupLogic? ToEnum(string value)
        {
            return value switch
            {
                "AND" => StructuredFilterGroupLogic.And,
                "OR" => StructuredFilterGroupLogic.Or,
                _ => null,
            };
        }
    }
}