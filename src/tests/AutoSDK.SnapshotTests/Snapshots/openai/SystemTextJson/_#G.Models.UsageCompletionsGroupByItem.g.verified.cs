//HintName: G.Models.UsageCompletionsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageCompletionsGroupByItem
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
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCompletionsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCompletionsGroupByItem value)
        {
            return value switch
            {
                UsageCompletionsGroupByItem.ProjectId => "project_id",
                UsageCompletionsGroupByItem.UserId => "user_id",
                UsageCompletionsGroupByItem.ApiKeyId => "api_key_id",
                UsageCompletionsGroupByItem.Model => "model",
                UsageCompletionsGroupByItem.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCompletionsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageCompletionsGroupByItem.ProjectId,
                "user_id" => UsageCompletionsGroupByItem.UserId,
                "api_key_id" => UsageCompletionsGroupByItem.ApiKeyId,
                "model" => UsageCompletionsGroupByItem.Model,
                "batch" => UsageCompletionsGroupByItem.Batch,
                _ => null,
            };
        }
    }
}