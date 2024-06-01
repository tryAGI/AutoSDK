//HintName: G.Models.WebhookStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new state. Can be `pending`, `success`, `failure`, or `error`.
    /// </summary>
    public enum WebhookStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
                WebhookStatusState.Pending => "pending",
                WebhookStatusState.Success => "success",
                WebhookStatusState.Failure => "failure",
                WebhookStatusState.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusState ToEnum(string value)
        {
            return value switch
            {
                "pending" => WebhookStatusState.Pending,
                "success" => WebhookStatusState.Success,
                "failure" => WebhookStatusState.Failure,
                "error" => WebhookStatusState.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}