//HintName: G.Models.UsageEmbeddingsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageEmbeddingsGroupByItem
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