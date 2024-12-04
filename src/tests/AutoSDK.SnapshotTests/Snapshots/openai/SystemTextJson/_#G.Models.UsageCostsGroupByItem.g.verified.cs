//HintName: G.Models.UsageCostsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageCostsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        LineItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCostsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCostsGroupByItem value)
        {
            return value switch
            {
                UsageCostsGroupByItem.ProjectId => "project_id",
                UsageCostsGroupByItem.LineItem => "line_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCostsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageCostsGroupByItem.ProjectId,
                "line_item" => UsageCostsGroupByItem.LineItem,
                _ => null,
            };
        }
    }
}