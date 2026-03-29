//HintName: G.Models.TestWebhookRequestDtoEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestWebhookRequestDtoEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/end")]
        ChatEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestWebhookRequestDtoEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestWebhookRequestDtoEventType value)
        {
            return value switch
            {
                TestWebhookRequestDtoEventType.ChatEnd => "chat/end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestWebhookRequestDtoEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/end" => TestWebhookRequestDtoEventType.ChatEnd,
                _ => null,
            };
        }
    }
}