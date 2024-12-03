//HintName: G.Models.HovercardContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HovercardContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("octicon", Required = global::Newtonsoft.Json.Required.Always)]
        public string Octicon { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HovercardContext" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="octicon"></param>
        public HovercardContext(
            string message,
            string octicon)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Octicon = octicon ?? throw new global::System.ArgumentNullException(nameof(octicon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HovercardContext" /> class.
        /// </summary>
        public HovercardContext()
        {
        }
    }
}