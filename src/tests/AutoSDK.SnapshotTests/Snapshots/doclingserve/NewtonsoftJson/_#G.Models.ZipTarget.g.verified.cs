//HintName: G.Models.ZipTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ZipTarget
    {
        /// <summary>
        /// Default Value: zip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipTarget" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: zip
        /// </param>
        public ZipTarget(
            string? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipTarget" /> class.
        /// </summary>
        public ZipTarget()
        {
        }
    }
}