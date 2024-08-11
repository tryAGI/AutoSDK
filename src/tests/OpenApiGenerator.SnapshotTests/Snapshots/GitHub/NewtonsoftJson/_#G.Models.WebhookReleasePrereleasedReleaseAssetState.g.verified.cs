//HintName: G.Models.WebhookReleasePrereleasedReleaseAssetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the release asset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookReleasePrereleasedReleaseAssetState
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
    public static class WebhookReleasePrereleasedReleaseAssetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedReleaseAssetState value)
        {
            return value switch
            {
                WebhookReleasePrereleasedReleaseAssetState.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedReleaseAssetState? ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => WebhookReleasePrereleasedReleaseAssetState.Uploaded,
                _ => null,
            };
        }
    }
}