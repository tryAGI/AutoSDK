//HintName: G.Models.RestorePropertyResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestorePropertyResponseData
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
        /// Initializes a new instance of the <see cref="RestorePropertyResponseData" /> class.
        /// </summary>
        /// <param name="ok"></param>
        public RestorePropertyResponseData(
            bool ok)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePropertyResponseData" /> class.
        /// </summary>
        public RestorePropertyResponseData()
        {
        }
    }
}