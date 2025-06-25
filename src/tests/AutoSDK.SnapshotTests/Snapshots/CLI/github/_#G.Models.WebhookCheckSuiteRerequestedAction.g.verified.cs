﻿//HintName: G.Models.WebhookCheckSuiteRerequestedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRerequestedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Rerequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRerequestedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedAction value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedAction.Rerequested => "rerequested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedAction? ToEnum(string value)
        {
            return value switch
            {
                "rerequested" => WebhookCheckSuiteRerequestedAction.Rerequested,
                _ => null,
            };
        }
    }
}