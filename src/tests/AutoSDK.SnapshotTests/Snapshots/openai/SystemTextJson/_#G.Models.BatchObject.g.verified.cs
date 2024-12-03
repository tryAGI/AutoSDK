//HintName: G.Models.BatchObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `batch`.
    /// </summary>
    public enum BatchObject
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObject value)
        {
            return value switch
            {
                BatchObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObject? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchObject.Batch,
                _ => null,
            };
        }
    }
}