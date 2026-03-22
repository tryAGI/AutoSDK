//HintName: G.Models.WebhookStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new state. Can be `pending`, `success`, `failure`, or `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusState value)
        {
            return value switch
            {
                WebhookStatusState.Error => "error",
                WebhookStatusState.Failure => "failure",
                WebhookStatusState.Pending => "pending",
                WebhookStatusState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusState? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebhookStatusState.Error,
                "failure" => WebhookStatusState.Failure,
                "pending" => WebhookStatusState.Pending,
                "success" => WebhookStatusState.Success,
                _ => null,
            };
        }
    }
}