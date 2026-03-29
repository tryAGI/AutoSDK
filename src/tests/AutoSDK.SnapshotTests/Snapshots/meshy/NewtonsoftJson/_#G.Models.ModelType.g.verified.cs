//HintName: G.Models.ModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lowpoly")]
        Lowpoly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelType value)
        {
            return value switch
            {
                ModelType.Lowpoly => "lowpoly",
                ModelType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelType? ToEnum(string value)
        {
            return value switch
            {
                "lowpoly" => ModelType.Lowpoly,
                "standard" => ModelType.Standard,
                _ => null,
            };
        }
    }
}