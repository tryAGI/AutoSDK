//HintName: G.Models.TracerSessionWithoutVirtualFieldsTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TracerSessionWithoutVirtualFieldsTraceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="longlived")]
        Longlived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shortlived")]
        Shortlived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TracerSessionWithoutVirtualFieldsTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionWithoutVirtualFieldsTraceTier value)
        {
            return value switch
            {
                TracerSessionWithoutVirtualFieldsTraceTier.Longlived => "longlived",
                TracerSessionWithoutVirtualFieldsTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionWithoutVirtualFieldsTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TracerSessionWithoutVirtualFieldsTraceTier.Longlived,
                "shortlived" => TracerSessionWithoutVirtualFieldsTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}