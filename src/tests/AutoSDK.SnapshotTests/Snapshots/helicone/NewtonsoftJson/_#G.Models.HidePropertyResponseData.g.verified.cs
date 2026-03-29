//HintName: G.Models.HidePropertyResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HidePropertyResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ok", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Ok { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HidePropertyResponseData" /> class.
        /// </summary>
        /// <param name="ok"></param>
        public HidePropertyResponseData(
            bool ok)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HidePropertyResponseData" /> class.
        /// </summary>
        public HidePropertyResponseData()
        {
        }
    }
}