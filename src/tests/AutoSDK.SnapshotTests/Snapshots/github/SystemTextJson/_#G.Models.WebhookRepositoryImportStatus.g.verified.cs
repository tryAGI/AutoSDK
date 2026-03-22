//HintName: G.Models.WebhookRepositoryImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryImportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryImportStatus value)
        {
            return value switch
            {
                WebhookRepositoryImportStatus.Cancelled => "cancelled",
                WebhookRepositoryImportStatus.Failure => "failure",
                WebhookRepositoryImportStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryImportStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookRepositoryImportStatus.Cancelled,
                "failure" => WebhookRepositoryImportStatus.Failure,
                "success" => WebhookRepositoryImportStatus.Success,
                _ => null,
            };
        }
    }
}