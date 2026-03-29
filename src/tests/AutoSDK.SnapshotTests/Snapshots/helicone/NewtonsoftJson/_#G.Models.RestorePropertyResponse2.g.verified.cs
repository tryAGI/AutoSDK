//HintName: G.Models.RestorePropertyResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestorePropertyResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public object Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RestorePropertyResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePropertyResponse2" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="data"></param>
        public RestorePropertyResponse2(
            object error,
            global::G.RestorePropertyResponseData data)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePropertyResponse2" /> class.
        /// </summary>
        public RestorePropertyResponse2()
        {
        }
    }
}