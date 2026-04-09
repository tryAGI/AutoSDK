//HintName: G.Models.FineRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fine-granular reference item that can capture span range info.
    /// </summary>
    public sealed partial class FineRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("$ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string x_ref { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range")]
        public global::System.Collections.Generic.IList<int>? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineRef" /> class.
        /// </summary>
        /// <param name="x_ref"></param>
        /// <param name="range"></param>
        public FineRef(
            string x_ref,
            global::System.Collections.Generic.IList<int>? range)
        {
            this.x_ref = x_ref ?? throw new global::System.ArgumentNullException(nameof(x_ref));
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineRef" /> class.
        /// </summary>
        public FineRef()
        {
        }
    }
}