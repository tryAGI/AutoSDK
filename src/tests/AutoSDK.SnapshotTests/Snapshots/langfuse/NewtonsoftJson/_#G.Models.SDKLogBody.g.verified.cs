//HintName: G.Models.SDKLogBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SDKLogBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log", Required = global::Newtonsoft.Json.Required.Always)]
        public object Log { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SDKLogBody" /> class.
        /// </summary>
        /// <param name="log"></param>
        public SDKLogBody(
            object log)
        {
            this.Log = log ?? throw new global::System.ArgumentNullException(nameof(log));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SDKLogBody" /> class.
        /// </summary>
        public SDKLogBody()
        {
        }
    }
}