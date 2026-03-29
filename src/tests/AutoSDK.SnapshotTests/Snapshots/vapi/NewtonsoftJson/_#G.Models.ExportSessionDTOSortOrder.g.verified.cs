//HintName: G.Models.ExportSessionDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExportSessionDTOSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportSessionDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportSessionDTOSortOrder value)
        {
            return value switch
            {
                ExportSessionDTOSortOrder.Asc => "ASC",
                ExportSessionDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportSessionDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ExportSessionDTOSortOrder.Asc,
                "DESC" => ExportSessionDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}