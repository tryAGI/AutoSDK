//HintName: G.Models.ErrorItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DoclingComponentTypeJsonConverter))]
        public global::G.DoclingComponentType ComponentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("module_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModuleName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItem" /> class.
        /// </summary>
        /// <param name="componentType"></param>
        /// <param name="moduleName"></param>
        /// <param name="errorMessage"></param>
        public ErrorItem(
            global::G.DoclingComponentType componentType,
            string moduleName,
            string errorMessage)
        {
            this.ComponentType = componentType;
            this.ModuleName = moduleName ?? throw new global::System.ArgumentNullException(nameof(moduleName));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItem" /> class.
        /// </summary>
        public ErrorItem()
        {
        }
    }
}