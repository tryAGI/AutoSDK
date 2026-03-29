//HintName: G.Models.AnnotateSessionsResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotateSessionsResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InsertedSessionAnnotation> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateSessionsResponseBody" /> class.
        /// </summary>
        /// <param name="data"></param>
        public AnnotateSessionsResponseBody(
            global::System.Collections.Generic.IList<global::G.InsertedSessionAnnotation> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateSessionsResponseBody" /> class.
        /// </summary>
        public AnnotateSessionsResponseBody()
        {
        }
    }
}