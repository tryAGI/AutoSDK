//HintName: G.Models.InBodyTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InBodyTarget
    {
        /// <summary>
        /// Default Value: inbody
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InBodyTarget" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: inbody
        /// </param>
        public InBodyTarget(
            string? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InBodyTarget" /> class.
        /// </summary>
        public InBodyTarget()
        {
        }
    }
}