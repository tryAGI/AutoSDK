//HintName: G.Models.DepthEstimationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for depth estimation inference.<br/>
    /// Attributes:<br/>
    ///     normalized_depth (List[List[float]]): The normalized depth map as a 2D array of floats between 0 and 1.<br/>
    ///     image (Optional[str]): Base64 encoded visualization of the depth map if visualize_predictions is True.<br/>
    ///     time (float): The processing time in seconds.<br/>
    ///     visualization (Optional[str]): Base64 encoded visualization of the depth map if visualize_predictions is True.
    /// </summary>
    public sealed partial class DepthEstimationResponse
    {
        /// <summary>
        /// The normalized depth map as a 2D array of floats between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> NormalizedDepth { get; set; }

        /// <summary>
        /// Base64 encoded visualization of the depth map if visualize_predictions is True
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthEstimationResponse" /> class.
        /// </summary>
        /// <param name="normalizedDepth">
        /// The normalized depth map as a 2D array of floats between 0 and 1
        /// </param>
        /// <param name="image">
        /// Base64 encoded visualization of the depth map if visualize_predictions is True
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DepthEstimationResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> normalizedDepth,
            string? image)
        {
            this.NormalizedDepth = normalizedDepth ?? throw new global::System.ArgumentNullException(nameof(normalizedDepth));
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthEstimationResponse" /> class.
        /// </summary>
        public DepthEstimationResponse()
        {
        }
    }
}