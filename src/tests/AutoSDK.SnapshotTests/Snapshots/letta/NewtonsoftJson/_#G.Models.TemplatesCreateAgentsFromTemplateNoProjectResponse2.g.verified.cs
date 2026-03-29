//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateNoProjectResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="limit"></param>
        public TemplatesCreateAgentsFromTemplateNoProjectResponse2(
            string message,
            double limit)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse2" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateNoProjectResponse2()
        {
        }
    }
}