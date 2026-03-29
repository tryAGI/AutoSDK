//HintName: G.Models.GetWorkflowResponseWorkflowContents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The workflow definition/configuration object<br/>
    /// Example: {"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}
    /// </summary>
    public sealed partial class GetWorkflowResponseWorkflowContents
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}