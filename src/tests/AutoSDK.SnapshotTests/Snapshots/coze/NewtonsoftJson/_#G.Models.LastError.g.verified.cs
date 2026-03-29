//HintName: G.Models.LastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LastError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg", Required = global::Newtonsoft.Json.Required.Always)]
        public string Msg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        public LastError(
            int code,
            string msg)
        {
            this.Code = code;
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastError" /> class.
        /// </summary>
        public LastError()
        {
        }
    }
}