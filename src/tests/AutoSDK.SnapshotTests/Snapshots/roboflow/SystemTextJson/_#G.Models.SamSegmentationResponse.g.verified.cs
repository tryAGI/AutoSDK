//HintName: G.Models.SamSegmentationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM segmentation response.<br/>
    /// Attributes:<br/>
    ///     masks (Union[List[List[List[int]]], Any]): The set of output masks.<br/>
    ///     low_res_masks (Union[List[List[List[int]]], Any]): The set of output low-resolution masks.<br/>
    ///     time (float): The time in seconds it took to produce the segmentation including preprocessing.
    /// </summary>
    public sealed partial class SamSegmentationResponse
    {
        /// <summary>
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are the same as the dimensions of the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> Masks { get; set; }

        /// <summary>
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_res_masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> LowResMasks { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationResponse" /> class.
        /// </summary>
        /// <param name="masks">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are the same as the dimensions of the input image.
        /// </param>
        /// <param name="lowResMasks">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamSegmentationResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> masks,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> lowResMasks,
            double time)
        {
            this.Masks = masks;
            this.LowResMasks = lowResMasks;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationResponse" /> class.
        /// </summary>
        public SamSegmentationResponse()
        {
        }
    }
}