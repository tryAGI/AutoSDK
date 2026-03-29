//HintName: G.Models.ListDatasetsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum ListDatasetsStatus
    {
        /// <summary>
        /// 'active' (default) returns only active datasets, 'deleted' returns only deleted/archived datasets, 'all' returns both
        /// </summary>
        Active,
        /// <summary>
        /// 'active' (default) returns only active datasets, 'deleted' returns only deleted/archived datasets, 'all' returns both
        /// </summary>
        All,
        /// <summary>
        /// 'active' (default) returns only active datasets, 'deleted' returns only deleted/archived datasets, 'all' returns both
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDatasetsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDatasetsStatus value)
        {
            return value switch
            {
                ListDatasetsStatus.Active => "active",
                ListDatasetsStatus.All => "all",
                ListDatasetsStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDatasetsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListDatasetsStatus.Active,
                "all" => ListDatasetsStatus.All,
                "deleted" => ListDatasetsStatus.Deleted,
                _ => null,
            };
        }
    }
}