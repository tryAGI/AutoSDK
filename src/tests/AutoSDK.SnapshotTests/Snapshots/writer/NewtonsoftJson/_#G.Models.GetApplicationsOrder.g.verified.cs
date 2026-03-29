//HintName: G.Models.GetApplicationsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetApplicationsOrder
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
    public static class GetApplicationsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetApplicationsOrder value)
        {
            return value switch
            {
                GetApplicationsOrder.Asc => "asc",
                GetApplicationsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetApplicationsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetApplicationsOrder.Asc,
                "desc" => GetApplicationsOrder.Desc,
                _ => null,
            };
        }
    }
}