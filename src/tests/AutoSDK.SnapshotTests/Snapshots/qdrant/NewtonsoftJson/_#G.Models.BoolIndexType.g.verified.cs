//HintName: G.Models.BoolIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BoolIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bool")]
        Bool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoolIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoolIndexType value)
        {
            return value switch
            {
                BoolIndexType.Bool => "bool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoolIndexType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => BoolIndexType.Bool,
                _ => null,
            };
        }
    }
}