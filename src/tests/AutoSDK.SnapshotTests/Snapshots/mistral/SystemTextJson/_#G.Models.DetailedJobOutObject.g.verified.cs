//HintName: G.Models.DetailedJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: job
    /// </summary>
    public enum DetailedJobOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailedJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedJobOutObject value)
        {
            return value switch
            {
                DetailedJobOutObject.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job" => DetailedJobOutObject.Job,
                _ => null,
            };
        }
    }
}