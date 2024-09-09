//HintName: G.Models.ChecksCreateRequestOutputAnnotationAnnotationLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of the annotation.
    /// </summary>
    public enum ChecksCreateRequestOutputAnnotationAnnotationLevel
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
    public static class ChecksCreateRequestOutputAnnotationAnnotationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksCreateRequestOutputAnnotationAnnotationLevel value)
        {
            return value switch
            {
                ChecksCreateRequestOutputAnnotationAnnotationLevel.Notice => "notice",
                ChecksCreateRequestOutputAnnotationAnnotationLevel.Warning => "warning",
                ChecksCreateRequestOutputAnnotationAnnotationLevel.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksCreateRequestOutputAnnotationAnnotationLevel? ToEnum(string value)
        {
            return value switch
            {
                "notice" => ChecksCreateRequestOutputAnnotationAnnotationLevel.Notice,
                "warning" => ChecksCreateRequestOutputAnnotationAnnotationLevel.Warning,
                "failure" => ChecksCreateRequestOutputAnnotationAnnotationLevel.Failure,
                _ => null,
            };
        }
    }
}