//HintName: G.Models.WebhookCreateRefType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Git ref object created in the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCreateRefType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCreateRefTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCreateRefType value)
        {
            return value switch
            {
                WebhookCreateRefType.Tag => "tag",
                WebhookCreateRefType.Branch => "branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCreateRefType? ToEnum(string value)
        {
            return value switch
            {
                "tag" => WebhookCreateRefType.Tag,
                "branch" => WebhookCreateRefType.Branch,
                _ => null,
            };
        }
    }
}