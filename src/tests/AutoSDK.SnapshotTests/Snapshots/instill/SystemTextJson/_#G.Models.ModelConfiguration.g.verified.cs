//HintName: G.Models.ModelConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model configuration. This field is validated against the model<br/>
    /// specification in the model definition (i.e. the `model_spec` field in the<br/>
    /// model definition).
    /// </summary>
    public sealed partial class ModelConfiguration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}