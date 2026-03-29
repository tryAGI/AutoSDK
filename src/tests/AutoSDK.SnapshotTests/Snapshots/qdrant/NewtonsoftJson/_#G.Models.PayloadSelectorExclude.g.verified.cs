//HintName: G.Models.PayloadSelectorExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadSelectorExclude
    {
        /// <summary>
        /// Exclude this fields from returning payload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Exclude { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadSelectorExclude" /> class.
        /// </summary>
        /// <param name="exclude">
        /// Exclude this fields from returning payload
        /// </param>
        public PayloadSelectorExclude(
            global::System.Collections.Generic.IList<string> exclude)
        {
            this.Exclude = exclude ?? throw new global::System.ArgumentNullException(nameof(exclude));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadSelectorExclude" /> class.
        /// </summary>
        public PayloadSelectorExclude()
        {
        }
    }
}