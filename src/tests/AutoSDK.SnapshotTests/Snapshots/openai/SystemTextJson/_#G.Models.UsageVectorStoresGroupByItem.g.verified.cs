//HintName: G.Models.UsageVectorStoresGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageVectorStoresGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageVectorStoresGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageVectorStoresGroupByItem value)
        {
            return value switch
            {
                UsageVectorStoresGroupByItem.ProjectId => "project_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageVectorStoresGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageVectorStoresGroupByItem.ProjectId,
                _ => null,
            };
        }
    }
}