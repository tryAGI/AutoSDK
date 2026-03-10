//HintName: G.Models.PositionInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PositionInput
    {
        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionInput" /> class.
        /// </summary>
        /// <param name="x">
        /// Default Value: 0F
        /// </param>
        /// <param name="y">
        /// Default Value: 0F
        /// </param>
        public PositionInput(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionInput" /> class.
        /// </summary>
        public PositionInput()
        {
        }
    }
}