//HintName: G.Models.ListVectorStoreFilesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListVectorStoreFilesOrder
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

    public static class ListVectorStoreFilesOrderExtensions
    {
        public static string ToValueString(this ListVectorStoreFilesOrder value)
        {
            return value switch
            {
                ListVectorStoreFilesOrder.Asc => "asc",
                ListVectorStoreFilesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoreFilesOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListVectorStoreFilesOrder.Asc,
                "desc" => ListVectorStoreFilesOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoreFilesOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListVectorStoreFilesOrder.Asc,
                1 => ListVectorStoreFilesOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}