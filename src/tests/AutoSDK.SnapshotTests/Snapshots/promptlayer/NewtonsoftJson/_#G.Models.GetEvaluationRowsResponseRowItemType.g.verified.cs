//HintName: G.Models.GetEvaluationRowsResponseRowItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEvaluationRowsResponseRowItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eval")]
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvaluationRowsResponseRowItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvaluationRowsResponseRowItemType value)
        {
            return value switch
            {
                GetEvaluationRowsResponseRowItemType.Dataset => "dataset",
                GetEvaluationRowsResponseRowItemType.Eval => "eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvaluationRowsResponseRowItemType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => GetEvaluationRowsResponseRowItemType.Dataset,
                "eval" => GetEvaluationRowsResponseRowItemType.Eval,
                _ => null,
            };
        }
    }
}