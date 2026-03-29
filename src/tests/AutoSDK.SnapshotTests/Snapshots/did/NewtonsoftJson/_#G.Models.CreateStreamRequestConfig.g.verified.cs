//HintName: G.Models.CreateStreamRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateStreamRequestConfig
    {
        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamRequestConfig" /> class.
        /// </summary>
        /// <param name="stitch">
        /// Stitch back the animated result to the original image
        /// </param>
        public CreateStreamRequestConfig(
            bool? stitch)
        {
            this.Stitch = stitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamRequestConfig" /> class.
        /// </summary>
        public CreateStreamRequestConfig()
        {
        }
    }
}