//HintName: G.Models.UsageCodeInterpreterSessionsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageCodeInterpreterSessionsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCodeInterpreterSessionsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCodeInterpreterSessionsGroupByItem value)
        {
            return value switch
            {
                UsageCodeInterpreterSessionsGroupByItem.ProjectId => "project_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCodeInterpreterSessionsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageCodeInterpreterSessionsGroupByItem.ProjectId,
                _ => null,
            };
        }
    }
}