//HintName: G.Models.WebhooksReleaseAssetsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the release asset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReleaseAssetsState
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
    public static class WebhooksReleaseAssetsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReleaseAssetsState value)
        {
            return value switch
            {
                WebhooksReleaseAssetsState.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAssetsState? ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => WebhooksReleaseAssetsState.Uploaded,
                _ => null,
            };
        }
    }
}