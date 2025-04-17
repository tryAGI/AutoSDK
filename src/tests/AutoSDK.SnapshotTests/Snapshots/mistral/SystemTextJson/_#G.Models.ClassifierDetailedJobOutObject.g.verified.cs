//HintName: G.Models.ClassifierDetailedJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: job
    /// </summary>
    public enum ClassifierDetailedJobOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierDetailedJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutObject value)
        {
            return value switch
            {
                ClassifierDetailedJobOutObject.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierDetailedJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job" => ClassifierDetailedJobOutObject.Job,
                _ => null,
            };
        }
    }
}