//HintName: G.Models.GenerateImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"data":[{"seed":12345,"prompt":"A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there\u0027s an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.","resolution":"1024x1024","url":"https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g","is_image_safe":true},{"seed":12345,"prompt":"A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there\u0027s an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.","resolution":"1024x1024","url":"https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g","is_image_safe":true}],"created":"2000-01-23T04:56:07.0000000\u002B00:00"}
    /// </summary>
    public sealed partial class GenerateImageResponse
    {
        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// A list of ImageObjects that contain the generated image(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ImageObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list of ImageObjects that contain the generated image(s).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageResponse(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::G.ImageObject> data)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        public GenerateImageResponse()
        {
        }
    }
}