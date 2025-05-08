//HintName: G.Models.GetEvalRunOutputItemsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEvalRunOutputItemsOrder
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
    public static class GetEvalRunOutputItemsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunOutputItemsOrder value)
        {
            return value switch
            {
                GetEvalRunOutputItemsOrder.Asc => "asc",
                GetEvalRunOutputItemsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunOutputItemsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetEvalRunOutputItemsOrder.Asc,
                "desc" => GetEvalRunOutputItemsOrder.Desc,
                _ => null,
            };
        }
    }
}