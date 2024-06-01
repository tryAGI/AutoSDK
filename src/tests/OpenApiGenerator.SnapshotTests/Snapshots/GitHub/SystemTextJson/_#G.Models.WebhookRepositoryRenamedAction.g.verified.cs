//HintName: G.Models.WebhookRepositoryRenamedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryRenamedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Renamed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryRenamedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryRenamedAction value)
        {
            return value switch
            {
                WebhookRepositoryRenamedAction.Renamed => "renamed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryRenamedAction ToEnum(string value)
        {
            return value switch
            {
                "renamed" => WebhookRepositoryRenamedAction.Renamed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}