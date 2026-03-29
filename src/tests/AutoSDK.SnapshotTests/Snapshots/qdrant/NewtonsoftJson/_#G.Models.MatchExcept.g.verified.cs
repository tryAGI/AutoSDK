//HintName: G.Models.MatchExcept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Should have at least one value not matching the any given values
    /// </summary>
    public sealed partial class MatchExcept
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("except", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyVariants Except { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchExcept" /> class.
        /// </summary>
        /// <param name="except"></param>
        public MatchExcept(
            global::G.AnyVariants except)
        {
            this.Except = except;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchExcept" /> class.
        /// </summary>
        public MatchExcept()
        {
        }
    }
}