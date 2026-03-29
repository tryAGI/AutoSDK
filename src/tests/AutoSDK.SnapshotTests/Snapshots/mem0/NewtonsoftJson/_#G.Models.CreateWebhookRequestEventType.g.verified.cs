//HintName: G.Models.CreateWebhookRequestEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWebhookRequestEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory:add")]
        Memory_add,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory:categorize")]
        Memory_categorize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory:delete")]
        Memory_delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memory:update")]
        Memory_update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookRequestEventType value)
        {
            return value switch
            {
                CreateWebhookRequestEventType.Memory_add => "memory:add",
                CreateWebhookRequestEventType.Memory_categorize => "memory:categorize",
                CreateWebhookRequestEventType.Memory_delete => "memory:delete",
                CreateWebhookRequestEventType.Memory_update => "memory:update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "memory:add" => CreateWebhookRequestEventType.Memory_add,
                "memory:categorize" => CreateWebhookRequestEventType.Memory_categorize,
                "memory:delete" => CreateWebhookRequestEventType.Memory_delete,
                "memory:update" => CreateWebhookRequestEventType.Memory_update,
                _ => null,
            };
        }
    }
}