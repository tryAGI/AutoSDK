//HintName: G.Models.ListEvalsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListEvalsOrder
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
    public static class ListEvalsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEvalsOrder value)
        {
            return value switch
            {
                ListEvalsOrder.Asc => "asc",
                ListEvalsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEvalsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListEvalsOrder.Asc,
                "desc" => ListEvalsOrder.Desc,
                _ => null,
            };
        }
    }
}