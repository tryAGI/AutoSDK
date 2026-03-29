//HintName: G.Models.DeleteOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PointsSelector Delete { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOperation" /> class.
        /// </summary>
        /// <param name="delete"></param>
        public DeleteOperation(
            global::G.PointsSelector delete)
        {
            this.Delete = delete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOperation" /> class.
        /// </summary>
        public DeleteOperation()
        {
        }
    }
}