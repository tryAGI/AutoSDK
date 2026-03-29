//HintName: G.Models.CreateBatchRequestCallObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchRequestCallObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public string? Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequestCallObject" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="task"></param>
        /// <param name="startTime"></param>
        public CreateBatchRequestCallObject(
            string phoneNumber,
            string? task,
            string? startTime)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Task = task;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequestCallObject" /> class.
        /// </summary>
        public CreateBatchRequestCallObject()
        {
        }
    }
}