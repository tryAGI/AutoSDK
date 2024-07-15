//HintName: G.Models.WebhookRepositoryImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookRepositoryImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
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
                WebhookRepositoryImportStatus.Success => "success",
                WebhookRepositoryImportStatus.Cancelled => "cancelled",
                WebhookRepositoryImportStatus.Failure => "failure",
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
                "success" => WebhookRepositoryImportStatus.Success,
                "cancelled" => WebhookRepositoryImportStatus.Cancelled,
                "failure" => WebhookRepositoryImportStatus.Failure,
                _ => null,
            };
        }
    }
}