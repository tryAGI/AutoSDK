//HintName: G.Models.InferenceRequestImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image data for inference request.<br/>
    /// Attributes:<br/>
    ///     type (str): The type of image data provided, one of 'url', 'base64', or 'numpy'.<br/>
    ///     value (Optional[Any]): Image data corresponding to the image type.
    /// </summary>
    public sealed partial class InferenceRequestImage
    {
        /// <summary>
        /// The type of image data provided, one of 'url', 'base64', or 'numpy'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Image data corresponding to the image type, if type = 'url' then value is a string containing the url of an image, else if type = 'base64' then value is a string containing base64 encoded image data, else if type = 'numpy' then value is binary numpy data serialized using pickle.dumps(); array should 3 dimensions, channels last, with values in the range [0,255].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestImage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of image data provided, one of 'url', 'base64', or 'numpy'
        /// </param>
        /// <param name="value">
        /// Image data corresponding to the image type, if type = 'url' then value is a string containing the url of an image, else if type = 'base64' then value is a string containing base64 encoded image data, else if type = 'numpy' then value is binary numpy data serialized using pickle.dumps(); array should 3 dimensions, channels last, with values in the range [0,255].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRequestImage(
            string type,
            object? value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestImage" /> class.
        /// </summary>
        public InferenceRequestImage()
        {
        }
    }
}