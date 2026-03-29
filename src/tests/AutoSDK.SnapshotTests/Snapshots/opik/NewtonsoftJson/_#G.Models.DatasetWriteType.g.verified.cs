//HintName: G.Models.DatasetWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetWriteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluation_suite")]
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