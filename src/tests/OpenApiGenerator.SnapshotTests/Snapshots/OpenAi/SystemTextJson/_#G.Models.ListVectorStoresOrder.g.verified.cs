//HintName: G.Models.ListVectorStoresOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListVectorStoresOrder
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

    public static class ListVectorStoresOrderExtensions
    {
        public static string ToValueString(this ListVectorStoresOrder value)
        {
            return value switch
            {
                ListVectorStoresOrder.Asc => "asc",
                ListVectorStoresOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoresOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListVectorStoresOrder.Asc,
                "desc" => ListVectorStoresOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListVectorStoresOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListVectorStoresOrder.Asc,
                1 => ListVectorStoresOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}