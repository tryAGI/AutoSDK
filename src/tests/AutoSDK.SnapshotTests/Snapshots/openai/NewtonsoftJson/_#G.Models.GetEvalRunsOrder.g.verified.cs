//HintName: G.Models.GetEvalRunsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEvalRunsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvalRunsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunsOrder value)
        {
            return value switch
            {
                GetEvalRunsOrder.Asc => "asc",
                GetEvalRunsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetEvalRunsOrder.Asc,
                "desc" => GetEvalRunsOrder.Desc,
                _ => null,
            };
        }
    }
}