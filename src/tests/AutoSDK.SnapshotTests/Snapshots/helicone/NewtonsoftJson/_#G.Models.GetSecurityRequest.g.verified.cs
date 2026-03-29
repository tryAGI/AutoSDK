//HintName: G.Models.GetSecurityRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSecurityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advanced", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Advanced { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="advanced"></param>
        public GetSecurityRequest(
            string text,
            bool advanced)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Advanced = advanced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityRequest" /> class.
        /// </summary>
        public GetSecurityRequest()
        {
        }
    }
}