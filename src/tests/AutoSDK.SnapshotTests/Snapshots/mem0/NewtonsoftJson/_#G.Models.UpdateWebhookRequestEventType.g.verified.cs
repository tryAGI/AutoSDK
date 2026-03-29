//HintName: G.Models.UpdateWebhookRequestEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateWebhookRequestEventType
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
    public static class UpdateWebhookRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookRequestEventType value)
        {
            return value switch
            {
                UpdateWebhookRequestEventType.Memory_add => "memory:add",
                UpdateWebhookRequestEventType.Memory_categorize => "memory:categorize",
                UpdateWebhookRequestEventType.Memory_delete => "memory:delete",
                UpdateWebhookRequestEventType.Memory_update => "memory:update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "memory:add" => UpdateWebhookRequestEventType.Memory_add,
                "memory:categorize" => UpdateWebhookRequestEventType.Memory_categorize,
                "memory:delete" => UpdateWebhookRequestEventType.Memory_delete,
                "memory:update" => UpdateWebhookRequestEventType.Memory_update,
                _ => null,
            };
        }
    }
}