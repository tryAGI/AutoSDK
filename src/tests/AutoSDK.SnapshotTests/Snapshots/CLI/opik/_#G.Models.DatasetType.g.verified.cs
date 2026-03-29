//HintName: G.Models.DatasetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetType
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
    public static class DatasetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetType value)
        {
            return value switch
            {
                DatasetType.Dataset => "dataset",
                DatasetType.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => DatasetType.Dataset,
                "evaluation_suite" => DatasetType.EvaluationSuite,
                _ => null,
            };
        }
    }
}