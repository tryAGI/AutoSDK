//HintName: G.Models.CredentialWebhookDTOOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CredentialWebhookDTOOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Creation,
        /// <summary>
        /// 
        /// </summary>
        Override,
        /// <summary>
        /// 
        /// </summary>
        Refresh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialWebhookDTOOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialWebhookDTOOperation value)
        {
            return value switch
            {
                CredentialWebhookDTOOperation.Creation => "creation",
                CredentialWebhookDTOOperation.Override => "override",
                CredentialWebhookDTOOperation.Refresh => "refresh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialWebhookDTOOperation? ToEnum(string value)
        {
            return value switch
            {
                "creation" => CredentialWebhookDTOOperation.Creation,
                "override" => CredentialWebhookDTOOperation.Override,
                "refresh" => CredentialWebhookDTOOperation.Refresh,
                _ => null,
            };
        }
    }
}