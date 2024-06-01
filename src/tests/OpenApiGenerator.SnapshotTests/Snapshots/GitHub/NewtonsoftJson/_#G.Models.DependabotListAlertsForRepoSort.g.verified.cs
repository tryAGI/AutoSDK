//HintName: G.Models.DependabotListAlertsForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotListAlertsForRepoSort
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
    public static class DependabotListAlertsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForRepoSort value)
        {
            return value switch
            {
                DependabotListAlertsForRepoSort.Created => "created",
                DependabotListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForRepoSort ToEnum(string value)
        {
            return value switch
            {
                "created" => DependabotListAlertsForRepoSort.Created,
                "updated" => DependabotListAlertsForRepoSort.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}