//HintName: G.Models.UsageModerationsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageModerationsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageModerationsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageModerationsGroupByItem value)
        {
            return value switch
            {
                UsageModerationsGroupByItem.ProjectId => "project_id",
                UsageModerationsGroupByItem.UserId => "user_id",
                UsageModerationsGroupByItem.ApiKeyId => "api_key_id",
                UsageModerationsGroupByItem.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageModerationsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageModerationsGroupByItem.ProjectId,
                "user_id" => UsageModerationsGroupByItem.UserId,
                "api_key_id" => UsageModerationsGroupByItem.ApiKeyId,
                "model" => UsageModerationsGroupByItem.Model,
                _ => null,
            };
        }
    }
}