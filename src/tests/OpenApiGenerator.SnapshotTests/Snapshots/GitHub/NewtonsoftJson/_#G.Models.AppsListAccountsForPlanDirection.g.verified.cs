//HintName: G.Models.AppsListAccountsForPlanDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppsListAccountsForPlanDirection
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
    public static class AppsListAccountsForPlanDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsListAccountsForPlanDirection value)
        {
            return value switch
            {
                AppsListAccountsForPlanDirection.Asc => "asc",
                AppsListAccountsForPlanDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsListAccountsForPlanDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => AppsListAccountsForPlanDirection.Asc,
                "desc" => AppsListAccountsForPlanDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}