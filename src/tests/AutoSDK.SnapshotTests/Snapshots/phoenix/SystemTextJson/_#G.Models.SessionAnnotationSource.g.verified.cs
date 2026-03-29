//HintName: G.Models.SessionAnnotationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionAnnotationSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionAnnotationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionAnnotationSource value)
        {
            return value switch
            {
                SessionAnnotationSource.Api => "API",
                SessionAnnotationSource.App => "APP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionAnnotationSource? ToEnum(string value)
        {
            return value switch
            {
                "API" => SessionAnnotationSource.Api,
                "APP" => SessionAnnotationSource.App,
                _ => null,
            };
        }
    }
}