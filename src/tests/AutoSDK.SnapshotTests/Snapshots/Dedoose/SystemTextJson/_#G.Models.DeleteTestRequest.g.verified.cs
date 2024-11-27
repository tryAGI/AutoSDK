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
        [global::System.Text.Json.Serialization.JsonPropertyName("objTest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrainingTest ObjTest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTestRequest" /> class.
        /// </summary>
        /// <param name="objTest"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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