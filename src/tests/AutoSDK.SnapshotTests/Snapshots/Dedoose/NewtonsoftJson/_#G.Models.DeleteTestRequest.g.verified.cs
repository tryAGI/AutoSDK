//HintName: G.Models.DeleteTestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objTest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TrainingTest ObjTest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTestRequest" /> class.
        /// </summary>
        /// <param name="objTest"></param>
        public DeleteTestRequest(
            global::G.TrainingTest objTest)
        {
            this.ObjTest = objTest ?? throw new global::System.ArgumentNullException(nameof(objTest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTestRequest" /> class.
        /// </summary>
        public DeleteTestRequest()
        {
        }
    }
}