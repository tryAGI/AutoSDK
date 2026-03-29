//HintName: G.Models.ListEvaluatorsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListEvaluatorsOrder
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
    public static class ListEvaluatorsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEvaluatorsOrder value)
        {
            return value switch
            {
                ListEvaluatorsOrder.Asc => "asc",
                ListEvaluatorsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEvaluatorsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListEvaluatorsOrder.Asc,
                "desc" => ListEvaluatorsOrder.Desc,
                _ => null,
            };
        }
    }
}