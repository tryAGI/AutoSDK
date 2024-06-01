//HintName: G.Models.WebhookDeleteRefType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Git ref object deleted in the repository.
    /// </summary>
    public enum WebhookDeleteRefType
    {
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Branch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeleteRefTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeleteRefType value)
        {
            return value switch
            {
                WebhookDeleteRefType.Tag => "tag",
                WebhookDeleteRefType.Branch => "branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeleteRefType ToEnum(string value)
        {
            return value switch
            {
                "tag" => WebhookDeleteRefType.Tag,
                "branch" => WebhookDeleteRefType.Branch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}