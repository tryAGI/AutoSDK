//HintName: G.Models.DatasetWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetWriteType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        EvaluationSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetWriteType value)
        {
            return value switch
            {
                DatasetWriteType.Dataset => "dataset",
                DatasetWriteType.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetWriteType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => DatasetWriteType.Dataset,
                "evaluation_suite" => DatasetWriteType.EvaluationSuite,
                _ => null,
            };
        }
    }
}