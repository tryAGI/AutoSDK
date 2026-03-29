//HintName: G.Models.DatasetPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetPublicType
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