//HintName: G.Models.ListFilesInVectorStoreBatchOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListFilesInVectorStoreBatchOrder
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
    public static class ListFilesInVectorStoreBatchOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesInVectorStoreBatchOrder value)
        {
            return value switch
            {
                ListFilesInVectorStoreBatchOrder.Asc => "asc",
                ListFilesInVectorStoreBatchOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesInVectorStoreBatchOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFilesInVectorStoreBatchOrder.Asc,
                "desc" => ListFilesInVectorStoreBatchOrder.Desc,
                _ => null,
            };
        }
    }
}