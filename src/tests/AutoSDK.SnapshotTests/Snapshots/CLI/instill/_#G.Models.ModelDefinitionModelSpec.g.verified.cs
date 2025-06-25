//HintName: G.Models.ModelDefinitionModelSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model specification represented by a JSON schema. It is used to<br/>
    /// validate the JSON configurations of a model created from a specific model<br/>
    /// source, and the resource spec which the model is desired to be deployed on.<br/>
    /// It must be a valid JSON that includes what fields are needed to<br/>
    /// create or display a model.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ModelDefinitionModelSpec
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}