//HintName: G.Models.ListFilesInVectorStoreBatchOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFilesInVectorStoreBatchOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
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