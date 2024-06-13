//HintName: G.Models.ListVectorStoreFilesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListVectorStoreFilesOrder
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVectorStoreFilesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVectorStoreFilesOrder value)
        {
            return value switch
            {
                ListVectorStoreFilesOrder.Asc => "asc",
                ListVectorStoreFilesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVectorStoreFilesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListVectorStoreFilesOrder.Asc,
                "desc" => ListVectorStoreFilesOrder.Desc,
                _ => null,
            };
        }
    }
}