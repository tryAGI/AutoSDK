//HintName: G.Models.UsageCostsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageCostsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_id")]
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line_item")]
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