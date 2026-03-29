//HintName: G.Models.FilterDateTypeColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// Date Type columns are columns where the rows store data as a date.<br/>
    /// Must be a valid column for the selected table.<br/>
    /// Example: created_at
    /// </summary>
    public enum FilterDateTypeColumnOnCallTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        EndedAt,
        /// <summary>
        /// 
        /// </summary>
        StartedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterDateTypeColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterDateTypeColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterDateTypeColumnOnCallTableColumn.EndedAt => "endedAt",
                FilterDateTypeColumnOnCallTableColumn.StartedAt => "startedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterDateTypeColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "endedAt" => FilterDateTypeColumnOnCallTableColumn.EndedAt,
                "startedAt" => FilterDateTypeColumnOnCallTableColumn.StartedAt,
                _ => null,
            };
        }
    }
}