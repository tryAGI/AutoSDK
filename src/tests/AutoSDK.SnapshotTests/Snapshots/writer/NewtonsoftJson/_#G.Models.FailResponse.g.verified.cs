//HintName: G.Models.FailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tpe", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tpe { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FailMessage> Errors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extras", Required = global::Newtonsoft.Json.Required.Always)]
        public object Extras { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResponse" /> class.
        /// </summary>
        /// <param name="tpe"></param>
        /// <param name="errors"></param>
        /// <param name="extras"></param>
        public FailResponse(
            string tpe,
            global::System.Collections.Generic.IList<global::G.FailMessage> errors,
            object extras)
        {
            this.Tpe = tpe ?? throw new global::System.ArgumentNullException(nameof(tpe));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Extras = extras ?? throw new global::System.ArgumentNullException(nameof(extras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResponse" /> class.
        /// </summary>
        public FailResponse()
        {
        }
    }
}