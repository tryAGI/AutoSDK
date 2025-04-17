//HintName: G.Models.ClassifierJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type of the fine-tuning job.<br/>
    /// Default Value: job
    /// </summary>
    public enum ClassifierJobOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutObject value)
        {
            return value switch
            {
                ClassifierJobOutObject.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job" => ClassifierJobOutObject.Job,
                _ => null,
            };
        }
    }
}