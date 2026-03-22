//HintName: G.Models.UsageImagesGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageImagesGroupByItem
    {
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
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        Size,
        /// <summary>
        /// 
        /// </summary>
        Source,
        /// <summary>
        /// 
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageImagesGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesGroupByItem value)
        {
            return value switch
            {
                UsageImagesGroupByItem.ApiKeyId => "api_key_id",
                UsageImagesGroupByItem.Model => "model",
                UsageImagesGroupByItem.ProjectId => "project_id",
                UsageImagesGroupByItem.Size => "size",
                UsageImagesGroupByItem.Source => "source",
                UsageImagesGroupByItem.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => UsageImagesGroupByItem.ApiKeyId,
                "model" => UsageImagesGroupByItem.Model,
                "project_id" => UsageImagesGroupByItem.ProjectId,
                "size" => UsageImagesGroupByItem.Size,
                "source" => UsageImagesGroupByItem.Source,
                "user_id" => UsageImagesGroupByItem.UserId,
                _ => null,
            };
        }
    }
}