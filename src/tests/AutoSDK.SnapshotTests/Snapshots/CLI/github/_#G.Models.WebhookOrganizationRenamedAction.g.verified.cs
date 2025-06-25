//HintName: G.Models.WebhookOrganizationRenamedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookOrganizationRenamedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Renamed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrganizationRenamedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrganizationRenamedAction value)
        {
            return value switch
            {
                WebhookOrganizationRenamedAction.Renamed => "renamed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrganizationRenamedAction? ToEnum(string value)
        {
            return value switch
            {
                "renamed" => WebhookOrganizationRenamedAction.Renamed,
                _ => null,
            };
        }
    }
}