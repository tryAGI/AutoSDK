//HintName: G.Models.ReposListForAuthenticatedUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: full_name
    /// </summary>
    public enum ReposListForAuthenticatedUserSort
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
    public static class ReposListForAuthenticatedUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForAuthenticatedUserSort value)
        {
            return value switch
            {
                ReposListForAuthenticatedUserSort.Created => "created",
                ReposListForAuthenticatedUserSort.FullName => "full_name",
                ReposListForAuthenticatedUserSort.Pushed => "pushed",
                ReposListForAuthenticatedUserSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForAuthenticatedUserSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => ReposListForAuthenticatedUserSort.Created,
                "full_name" => ReposListForAuthenticatedUserSort.FullName,
                "pushed" => ReposListForAuthenticatedUserSort.Pushed,
                "updated" => ReposListForAuthenticatedUserSort.Updated,
                _ => null,
            };
        }
    }
}