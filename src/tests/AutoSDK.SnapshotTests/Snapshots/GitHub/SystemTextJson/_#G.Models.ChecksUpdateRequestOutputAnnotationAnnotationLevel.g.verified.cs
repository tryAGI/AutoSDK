//HintName: G.Models.ChecksUpdateRequestOutputAnnotationAnnotationLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of the annotation.
    /// </summary>
    public enum ChecksUpdateRequestOutputAnnotationAnnotationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Notice,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Failure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksUpdateRequestOutputAnnotationAnnotationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksUpdateRequestOutputAnnotationAnnotationLevel value)
        {
            return value switch
            {
                ChecksUpdateRequestOutputAnnotationAnnotationLevel.Notice => "notice",
                ChecksUpdateRequestOutputAnnotationAnnotationLevel.Warning => "warning",
                ChecksUpdateRequestOutputAnnotationAnnotationLevel.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksUpdateRequestOutputAnnotationAnnotationLevel? ToEnum(string value)
        {
            return value switch
            {
                "notice" => ChecksUpdateRequestOutputAnnotationAnnotationLevel.Notice,
                "warning" => ChecksUpdateRequestOutputAnnotationAnnotationLevel.Warning,
                "failure" => ChecksUpdateRequestOutputAnnotationAnnotationLevel.Failure,
                _ => null,
            };
        }
    }
}