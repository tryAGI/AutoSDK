//HintName: G.Models.ListBatchesResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListBatchesResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    public static class ListBatchesResponseObjectExtensions
    {
        public static string ToValueString(this ListBatchesResponseObject value)
        {
            return value switch
            {
                ListBatchesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListBatchesResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListBatchesResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListBatchesResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListBatchesResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}