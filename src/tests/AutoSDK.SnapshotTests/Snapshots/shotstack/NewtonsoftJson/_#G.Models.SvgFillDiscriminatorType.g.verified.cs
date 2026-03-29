//HintName: G.Models.SvgFillDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgFillDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linear")]
        Linear,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="radial")]
        Radial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="solid")]
        Solid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgFillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgFillDiscriminatorType value)
        {
            return value switch
            {
                SvgFillDiscriminatorType.Linear => "linear",
                SvgFillDiscriminatorType.Radial => "radial",
                SvgFillDiscriminatorType.Solid => "solid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgFillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "linear" => SvgFillDiscriminatorType.Linear,
                "radial" => SvgFillDiscriminatorType.Radial,
                "solid" => SvgFillDiscriminatorType.Solid,
                _ => null,
            };
        }
    }
}