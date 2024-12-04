//HintName: G.Models.UsageImagesGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageImagesGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_id")]
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_id")]
        UserId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key_id")]
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="size")]
        Size,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source")]
        Source,
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
                UsageImagesGroupByItem.ProjectId => "project_id",
                UsageImagesGroupByItem.UserId => "user_id",
                UsageImagesGroupByItem.ApiKeyId => "api_key_id",
                UsageImagesGroupByItem.Model => "model",
                UsageImagesGroupByItem.Size => "size",
                UsageImagesGroupByItem.Source => "source",
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
                "project_id" => UsageImagesGroupByItem.ProjectId,
                "user_id" => UsageImagesGroupByItem.UserId,
                "api_key_id" => UsageImagesGroupByItem.ApiKeyId,
                "model" => UsageImagesGroupByItem.Model,
                "size" => UsageImagesGroupByItem.Size,
                "source" => UsageImagesGroupByItem.Source,
                _ => null,
            };
        }
    }
}