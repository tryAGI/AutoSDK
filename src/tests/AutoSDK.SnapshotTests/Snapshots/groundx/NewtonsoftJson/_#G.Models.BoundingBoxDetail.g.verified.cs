//HintName: G.Models.BoundingBoxDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BoundingBoxDetail
    {
        /// <summary>
        /// The x coordinate of the lower right corner of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottomRightX")]
        public double? BottomRightX { get; set; }

        /// <summary>
        /// The y coordinate of the lower right corner of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottomRightY")]
        public double? BottomRightY { get; set; }

        /// <summary>
        /// The page number the bounding box appears on, using a 1-based array indexing (starts with page 1, not page 0)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The x coordinate of the upper left corner of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topLeftX")]
        public double? TopLeftX { get; set; }

        /// <summary>
        /// The y coordinate of the upper left corner of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topLeftY")]
        public double? TopLeftY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBoxDetail" /> class.
        /// </summary>
        /// <param name="bottomRightX">
        /// The x coordinate of the lower right corner of the bounding box
        /// </param>
        /// <param name="bottomRightY">
        /// The y coordinate of the lower right corner of the bounding box
        /// </param>
        /// <param name="pageNumber">
        /// The page number the bounding box appears on, using a 1-based array indexing (starts with page 1, not page 0)
        /// </param>
        /// <param name="topLeftX">
        /// The x coordinate of the upper left corner of the bounding box
        /// </param>
        /// <param name="topLeftY">
        /// The y coordinate of the upper left corner of the bounding box
        /// </param>
        public BoundingBoxDetail(
            double? bottomRightX,
            double? bottomRightY,
            int? pageNumber,
            double? topLeftX,
            double? topLeftY)
        {
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
            this.PageNumber = pageNumber;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBoxDetail" /> class.
        /// </summary>
        public BoundingBoxDetail()
        {
        }
    }
}