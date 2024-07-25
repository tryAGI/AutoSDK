//HintName: G.Models.RunSchemaWithAnnotationQueueInfoTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunSchemaWithAnnotationQueueInfoTraceTier
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
    public static class RunSchemaWithAnnotationQueueInfoTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSchemaWithAnnotationQueueInfoTraceTier value)
        {
            return value switch
            {
                RunSchemaWithAnnotationQueueInfoTraceTier.Longlived => "longlived",
                RunSchemaWithAnnotationQueueInfoTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSchemaWithAnnotationQueueInfoTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => RunSchemaWithAnnotationQueueInfoTraceTier.Longlived,
                "shortlived" => RunSchemaWithAnnotationQueueInfoTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}