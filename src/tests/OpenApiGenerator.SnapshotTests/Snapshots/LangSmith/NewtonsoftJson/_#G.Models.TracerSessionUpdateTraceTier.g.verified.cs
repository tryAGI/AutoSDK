//HintName: G.Models.TracerSessionUpdateTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TracerSessionUpdateTraceTier
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
    public static class TracerSessionUpdateTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionUpdateTraceTier value)
        {
            return value switch
            {
                TracerSessionUpdateTraceTier.Longlived => "longlived",
                TracerSessionUpdateTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionUpdateTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TracerSessionUpdateTraceTier.Longlived,
                "shortlived" => TracerSessionUpdateTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}