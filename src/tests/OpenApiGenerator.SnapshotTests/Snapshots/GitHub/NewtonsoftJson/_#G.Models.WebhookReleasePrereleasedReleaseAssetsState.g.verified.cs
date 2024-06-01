//HintName: G.Models.WebhookReleasePrereleasedReleaseAssetsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the release asset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookReleasePrereleasedReleaseAssetsState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded")]
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleasePrereleasedReleaseAssetsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedReleaseAssetsState value)
        {
            return value switch
            {
                WebhookReleasePrereleasedReleaseAssetsState.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedReleaseAssetsState ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => WebhookReleasePrereleasedReleaseAssetsState.Uploaded,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}