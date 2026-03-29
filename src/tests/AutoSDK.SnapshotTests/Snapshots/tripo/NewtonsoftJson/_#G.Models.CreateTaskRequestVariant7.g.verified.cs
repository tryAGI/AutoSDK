//HintName: G.Models.CreateTaskRequestVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_model_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalModelTaskId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_format")]
        public string? OutFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateTaskRequestVariant7Animation Animation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant7" /> class.
        /// </summary>
        /// <param name="originalModelTaskId"></param>
        /// <param name="animation"></param>
        /// <param name="type"></param>
        /// <param name="outFormat"></param>
        public CreateTaskRequestVariant7(
            string originalModelTaskId,
            global::G.CreateTaskRequestVariant7Animation animation,
            global::G.CreateTaskRequestVariant7Type type,
            string? outFormat)
        {
            this.Type = type;
            this.OriginalModelTaskId = originalModelTaskId ?? throw new global::System.ArgumentNullException(nameof(originalModelTaskId));
            this.OutFormat = outFormat;
            this.Animation = animation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant7" /> class.
        /// </summary>
        public CreateTaskRequestVariant7()
        {
        }
    }
}