//HintName: G.Models.GetWorkflowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a single workflow's details
    /// </summary>
    public sealed partial class GetWorkflowResponse
    {
        /// <summary>
        /// The workflow details<br/>
        /// Example: {"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","is_public":true,"contents":{"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}}
        /// </summary>
        /// <example>{"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","is_public":true,"contents":{"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetWorkflowResponseWorkflow Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponse" /> class.
        /// </summary>
        /// <param name="workflow">
        /// The workflow details<br/>
        /// Example: {"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","is_public":true,"contents":{"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowResponse(
            global::G.GetWorkflowResponseWorkflow workflow)
        {
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponse" /> class.
        /// </summary>
        public GetWorkflowResponse()
        {
        }
    }
}