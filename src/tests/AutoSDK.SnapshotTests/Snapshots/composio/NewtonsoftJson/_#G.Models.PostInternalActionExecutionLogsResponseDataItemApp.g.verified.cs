//HintName: G.Models.PostInternalActionExecutionLogsResponseDataItemApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsResponseDataItemApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon", Required = global::Newtonsoft.Json.Required.Always)]
        public string Icon { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemApp" /> class.
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="name"></param>
        public PostInternalActionExecutionLogsResponseDataItemApp(
            string icon,
            string name)
        {
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemApp" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsResponseDataItemApp()
        {
        }
    }
}