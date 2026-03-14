//HintName: G.Models.WebGetToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebGetToolVariant2
    {
        /// <summary>
        /// This should always be `web_get`.<br/>
        /// Default Value: web_get<br/>
        /// Example: web_get
        /// </summary>
        /// <default>"web_get"</default>
        /// <example>web_get</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `web_get`.<br/>
        /// Default Value: web_get<br/>
        /// Example: web_get
        /// </param>
        public WebGetToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolVariant2" /> class.
        /// </summary>
        public WebGetToolVariant2()
        {
        }
    }
}