//HintName: G.Models.EnumFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// in: value is one of the listed values
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnumFilterOp
    {
        /// <summary>
        /// value is one of the listed values
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnumFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnumFilterOp value)
        {
            return value switch
            {
                EnumFilterOp.In => "in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnumFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "in" => EnumFilterOp.In,
                _ => null,
            };
        }
    }
}