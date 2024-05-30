//HintName: G.Models.ListFilesInVectorStoreBatchOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
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

    public static class ListFilesInVectorStoreBatchOrderExtensions
    {
        public static string ToValueString(this ListFilesInVectorStoreBatchOrder value)
        {
            return value switch
            {
                ListFilesInVectorStoreBatchOrder.Asc => "asc",
                ListFilesInVectorStoreBatchOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFilesInVectorStoreBatchOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFilesInVectorStoreBatchOrder.Asc,
                "desc" => ListFilesInVectorStoreBatchOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFilesInVectorStoreBatchOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListFilesInVectorStoreBatchOrder.Asc,
                1 => ListFilesInVectorStoreBatchOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}