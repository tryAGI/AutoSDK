﻿//HintName: G.Models.CustomRewardDefaultImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of default images for the reward.
    /// </summary>
    public sealed partial class CustomRewardDefaultImage
    {
        /// <summary>
        /// The URL to a small version of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_1x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url1x { get; set; }

        /// <summary>
        /// The URL to a medium version of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_2x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url2x { get; set; }

        /// <summary>
        /// The URL to a large version of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_4x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url4x { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardDefaultImage" /> class.
        /// </summary>
        /// <param name="url1x">
        /// The URL to a small version of the image.
        /// </param>
        /// <param name="url2x">
        /// The URL to a medium version of the image.
        /// </param>
        /// <param name="url4x">
        /// The URL to a large version of the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRewardDefaultImage(
            string url1x,
            string url2x,
            string url4x)
        {
            this.Url1x = url1x ?? throw new global::System.ArgumentNullException(nameof(url1x));
            this.Url2x = url2x ?? throw new global::System.ArgumentNullException(nameof(url2x));
            this.Url4x = url4x ?? throw new global::System.ArgumentNullException(nameof(url4x));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardDefaultImage" /> class.
        /// </summary>
        public CustomRewardDefaultImage()
        {
        }
    }
}