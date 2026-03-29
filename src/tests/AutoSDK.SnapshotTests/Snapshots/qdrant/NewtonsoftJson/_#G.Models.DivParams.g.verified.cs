//HintName: G.Models.DivParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DivParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Left { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Right { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("by_zero_default")]
        public float? ByZeroDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DivParams" /> class.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="byZeroDefault"></param>
        public DivParams(
            global::G.Expression left,
            global::G.Expression right,
            float? byZeroDefault)
        {
            this.Left = left;
            this.Right = right;
            this.ByZeroDefault = byZeroDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivParams" /> class.
        /// </summary>
        public DivParams()
        {
        }
    }
}