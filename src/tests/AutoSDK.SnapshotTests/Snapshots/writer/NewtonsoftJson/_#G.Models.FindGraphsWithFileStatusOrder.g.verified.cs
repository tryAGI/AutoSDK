//HintName: G.Models.FindGraphsWithFileStatusOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FindGraphsWithFileStatusOrder
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
    public static class FindGraphsWithFileStatusOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindGraphsWithFileStatusOrder value)
        {
            return value switch
            {
                FindGraphsWithFileStatusOrder.Asc => "asc",
                FindGraphsWithFileStatusOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindGraphsWithFileStatusOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => FindGraphsWithFileStatusOrder.Asc,
                "desc" => FindGraphsWithFileStatusOrder.Desc,
                _ => null,
            };
        }
    }
}