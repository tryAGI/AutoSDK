//HintName: G.Models.AttachedFunctionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedFunctionInfo
    {
        /// <summary>
        /// Name of the function (e.g., "record_counter", "statistics").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionName { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the attached function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Human-readable name for the attached function instance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionInfo" /> class.
        /// </summary>
        /// <param name="functionName">
        /// Name of the function (e.g., "record_counter", "statistics").
        /// </param>
        /// <param name="id">
        /// Unique identifier for the attached function.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the attached function instance.
        /// </param>
        public AttachedFunctionInfo(
            string functionName,
            string id,
            string name)
        {
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionInfo" /> class.
        /// </summary>
        public AttachedFunctionInfo()
        {
        }
    }
}