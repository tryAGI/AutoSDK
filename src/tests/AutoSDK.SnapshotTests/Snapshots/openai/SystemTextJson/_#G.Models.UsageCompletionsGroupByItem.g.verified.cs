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
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
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
                UsageCompletionsGroupByItem.ApiKeyId => "api_key_id",
                UsageCompletionsGroupByItem.Batch => "batch",
                UsageCompletionsGroupByItem.Model => "model",
                UsageCompletionsGroupByItem.ProjectId => "project_id",
                UsageCompletionsGroupByItem.UserId => "user_id",
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
                "api_key_id" => UsageCompletionsGroupByItem.ApiKeyId,
                "batch" => UsageCompletionsGroupByItem.Batch,
                "model" => UsageCompletionsGroupByItem.Model,
                "project_id" => UsageCompletionsGroupByItem.ProjectId,
                "user_id" => UsageCompletionsGroupByItem.UserId,
                _ => null,
            };
        }
    }
}