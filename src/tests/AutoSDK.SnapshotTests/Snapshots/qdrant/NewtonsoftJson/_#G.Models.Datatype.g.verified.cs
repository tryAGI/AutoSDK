//HintName: G.Models.Datatype.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Datatype
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float16")]
        Float16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float32")]
        Float32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uint8")]
        Uint8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatatypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Datatype value)
        {
            return value switch
            {
                Datatype.Float16 => "float16",
                Datatype.Float32 => "float32",
                Datatype.Uint8 => "uint8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Datatype? ToEnum(string value)
        {
            return value switch
            {
                "float16" => Datatype.Float16,
                "float32" => Datatype.Float32,
                "uint8" => Datatype.Uint8,
                _ => null,
            };
        }
    }
}