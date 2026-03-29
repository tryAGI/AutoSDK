//HintName: G.Models.DocumentElementCoordinate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentElementCoordinate
    {
        /// <summary>
        /// X coordinate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// Y coordinate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementCoordinate" /> class.
        /// </summary>
        /// <param name="x">
        /// X coordinate.
        /// </param>
        /// <param name="y">
        /// Y coordinate.
        /// </param>
        public DocumentElementCoordinate(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementCoordinate" /> class.
        /// </summary>
        public DocumentElementCoordinate()
        {
        }
    }
}