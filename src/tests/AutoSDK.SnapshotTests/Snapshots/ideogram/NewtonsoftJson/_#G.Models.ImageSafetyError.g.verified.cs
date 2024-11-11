//HintName: G.Models.ImageSafetyError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSafetyError
    {
        /// <summary>
        /// Example: Image provided failed safety check due to the inclusion of prohibited content.
        /// </summary>
        /// <example>Image provided failed safety check due to the inclusion of prohibited content.</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSafetyError" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Image provided failed safety check due to the inclusion of prohibited content.
        /// </param>
        public ImageSafetyError(
            string error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSafetyError" /> class.
        /// </summary>
        public ImageSafetyError()
        {
        }
    }
}