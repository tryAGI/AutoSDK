//HintName: G.Models.WebhooksRelease1AssetsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the release asset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRelease1AssetsState
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
    public static class WebhooksRelease1AssetsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRelease1AssetsState value)
        {
            return value switch
            {
                WebhooksRelease1AssetsState.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRelease1AssetsState? ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => WebhooksRelease1AssetsState.Uploaded,
                _ => null,
            };
        }
    }
}