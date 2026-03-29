//HintName: G.Models.GetInternalActionExecutionLogByIdResponseApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uniqueId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UniqueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon", Required = global::Newtonsoft.Json.Required.Always)]
        public string Icon { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseApp" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="uniqueId"></param>
        /// <param name="icon"></param>
        public GetInternalActionExecutionLogByIdResponseApp(
            string name,
            string uniqueId,
            string icon)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UniqueId = uniqueId ?? throw new global::System.ArgumentNullException(nameof(uniqueId));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseApp" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseApp()
        {
        }
    }
}