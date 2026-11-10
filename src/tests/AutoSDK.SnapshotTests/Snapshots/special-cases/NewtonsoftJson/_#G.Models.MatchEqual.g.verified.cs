//HintName: G.Models.MatchEqual.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatchEqual
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Equal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchEqual" /> class.
        /// </summary>
        /// <param name="equal"></param>
        public MatchEqual(
            string equal)
        {
            this.Equal = equal ?? throw new global::System.ArgumentNullException(nameof(equal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchEqual" /> class.
        /// </summary>
        public MatchEqual()
        {
        }

    }
}