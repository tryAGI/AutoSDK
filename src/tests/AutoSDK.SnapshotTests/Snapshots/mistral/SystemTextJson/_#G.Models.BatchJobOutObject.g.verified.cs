//HintName: G.Models.BatchJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: batch
    /// </summary>
    public enum BatchJobOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobOutObject value)
        {
            return value switch
            {
                BatchJobOutObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchJobOutObject.Batch,
                _ => null,
            };
        }
    }
}