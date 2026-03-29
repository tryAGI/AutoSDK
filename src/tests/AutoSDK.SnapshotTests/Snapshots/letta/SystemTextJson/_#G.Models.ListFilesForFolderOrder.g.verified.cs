//HintName: G.Models.ListFilesForFolderOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for files by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListFilesForFolderOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFilesForFolderOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesForFolderOrder value)
        {
            return value switch
            {
                ListFilesForFolderOrder.Asc => "asc",
                ListFilesForFolderOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesForFolderOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFilesForFolderOrder.Asc,
                "desc" => ListFilesForFolderOrder.Desc,
                _ => null,
            };
        }
    }
}