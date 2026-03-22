//HintName: G.Models.ReposListForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum ReposListForOrgSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        FullName,
        /// <summary>
        /// 
        /// </summary>
        Pushed,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForOrgSort value)
        {
            return value switch
            {
                ReposListForOrgSort.Created => "created",
                ReposListForOrgSort.FullName => "full_name",
                ReposListForOrgSort.Pushed => "pushed",
                ReposListForOrgSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForOrgSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => ReposListForOrgSort.Created,
                "full_name" => ReposListForOrgSort.FullName,
                "pushed" => ReposListForOrgSort.Pushed,
                "updated" => ReposListForOrgSort.Updated,
                _ => null,
            };
        }
    }
}