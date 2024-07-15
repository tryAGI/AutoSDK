//HintName: G.Models.AppsListAccountsForPlanSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppsListAccountsForPlanSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsListAccountsForPlanSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsListAccountsForPlanSort value)
        {
            return value switch
            {
                AppsListAccountsForPlanSort.Created => "created",
                AppsListAccountsForPlanSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsListAccountsForPlanSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => AppsListAccountsForPlanSort.Created,
                "updated" => AppsListAccountsForPlanSort.Updated,
                _ => null,
            };
        }
    }
}