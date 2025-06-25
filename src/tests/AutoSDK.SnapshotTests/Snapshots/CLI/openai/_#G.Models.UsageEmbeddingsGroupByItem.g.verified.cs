//HintName: G.Models.UsageEmbeddingsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageEmbeddingsGroupByItem
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
    public static class UsageEmbeddingsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageEmbeddingsGroupByItem value)
        {
            return value switch
            {
                UsageEmbeddingsGroupByItem.ProjectId => "project_id",
                UsageEmbeddingsGroupByItem.UserId => "user_id",
                UsageEmbeddingsGroupByItem.ApiKeyId => "api_key_id",
                UsageEmbeddingsGroupByItem.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageEmbeddingsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageEmbeddingsGroupByItem.ProjectId,
                "user_id" => UsageEmbeddingsGroupByItem.UserId,
                "api_key_id" => UsageEmbeddingsGroupByItem.ApiKeyId,
                "model" => UsageEmbeddingsGroupByItem.Model,
                _ => null,
            };
        }
    }
}