//HintName: G.Models.ListMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListMessagesOrder
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
    public static class ListMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessagesOrder value)
        {
            return value switch
            {
                ListMessagesOrder.Asc => "asc",
                ListMessagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessagesOrder.Asc,
                "desc" => ListMessagesOrder.Desc,
                _ => null,
            };
        }
    }
}