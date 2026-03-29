//HintName: G.Models.ObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2")]
        x2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3")]
        x3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4")]
        x4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5")]
        x5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectType value)
        {
            return value switch
            {
                ObjectType.x1 => "1",
                ObjectType.x2 => "2",
                ObjectType.x3 => "3",
                ObjectType.x4 => "4",
                ObjectType.x5 => "5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "1" => ObjectType.x1,
                "2" => ObjectType.x2,
                "3" => ObjectType.x3,
                "4" => ObjectType.x4,
                "5" => ObjectType.x5,
                _ => null,
            };
        }
    }
}