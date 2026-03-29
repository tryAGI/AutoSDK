//HintName: G.Models.ListCallsRequestFilterCriteriaDirectionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCallsRequestFilterCriteriaDirectionItem
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsRequestFilterCriteriaDirectionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsRequestFilterCriteriaDirectionItem value)
        {
            return value switch
            {
                ListCallsRequestFilterCriteriaDirectionItem.Inbound => "inbound",
                ListCallsRequestFilterCriteriaDirectionItem.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsRequestFilterCriteriaDirectionItem? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ListCallsRequestFilterCriteriaDirectionItem.Inbound,
                "outbound" => ListCallsRequestFilterCriteriaDirectionItem.Outbound,
                _ => null,
            };
        }
    }
}