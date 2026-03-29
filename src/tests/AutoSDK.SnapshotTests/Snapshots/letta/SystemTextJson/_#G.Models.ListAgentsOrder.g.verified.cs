//HintName: G.Models.ListAgentsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListAgentsOrder
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
    public static class ListAgentsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsOrder value)
        {
            return value switch
            {
                ListAgentsOrder.Asc => "asc",
                ListAgentsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAgentsOrder.Asc,
                "desc" => ListAgentsOrder.Desc,
                _ => null,
            };
        }
    }
}