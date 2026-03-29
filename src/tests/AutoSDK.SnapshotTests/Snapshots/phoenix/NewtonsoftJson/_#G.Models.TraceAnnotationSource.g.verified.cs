//HintName: G.Models.TraceAnnotationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceAnnotationSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API")]
        Api,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="APP")]
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceAnnotationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceAnnotationSource value)
        {
            return value switch
            {
                TraceAnnotationSource.Api => "API",
                TraceAnnotationSource.App => "APP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceAnnotationSource? ToEnum(string value)
        {
            return value switch
            {
                "API" => TraceAnnotationSource.Api,
                "APP" => TraceAnnotationSource.App,
                _ => null,
            };
        }
    }
}