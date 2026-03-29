//HintName: G.Models.ListFolderPassagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for passages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFolderPassagesOrder
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
    public static class ListFolderPassagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFolderPassagesOrder value)
        {
            return value switch
            {
                ListFolderPassagesOrder.Asc => "asc",
                ListFolderPassagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFolderPassagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFolderPassagesOrder.Asc,
                "desc" => ListFolderPassagesOrder.Desc,
                _ => null,
            };
        }
    }
}