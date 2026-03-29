//HintName: G.Models.DatasetPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetPublicType
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
    public static class DatasetPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetPublicType value)
        {
            return value switch
            {
                DatasetPublicType.Dataset => "dataset",
                DatasetPublicType.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetPublicType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => DatasetPublicType.Dataset,
                "evaluation_suite" => DatasetPublicType.EvaluationSuite,
                _ => null,
            };
        }
    }
}