//HintName: G.Models.ListAgentsForFolderOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsForFolderOrder
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
    public static class ListAgentsForFolderOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForFolderOrder value)
        {
            return value switch
            {
                ListAgentsForFolderOrder.Asc => "asc",
                ListAgentsForFolderOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForFolderOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAgentsForFolderOrder.Asc,
                "desc" => ListAgentsForFolderOrder.Desc,
                _ => null,
            };
        }
    }
}