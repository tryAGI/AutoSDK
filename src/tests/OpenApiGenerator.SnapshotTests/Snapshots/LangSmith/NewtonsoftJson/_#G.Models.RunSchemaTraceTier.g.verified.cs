//HintName: G.Models.RunSchemaTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunSchemaTraceTier
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
    public static class RunSchemaTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSchemaTraceTier value)
        {
            return value switch
            {
                RunSchemaTraceTier.Longlived => "longlived",
                RunSchemaTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSchemaTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => RunSchemaTraceTier.Longlived,
                "shortlived" => RunSchemaTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}