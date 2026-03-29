//HintName: G.Models.GetWorkflowResponseWorkflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The workflow details<br/>
    /// Example: {"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","is_public":true,"contents":{"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}}
    /// </summary>
    public sealed partial class GetWorkflowResponseWorkflow
    {
        /// <summary>
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </summary>
        /// <example>my-image-workflow</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </summary>
        /// <example>My Image Generation Workflow</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Display name/username of the owner<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::Newtonsoft.Json.JsonProperty("user_nickname", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserNickname { get; set; } = default!;

        /// <summary>
        /// ISO8601 timestamp of workflow creation<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the workflow is publicly visible<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPublic { get; set; } = default!;

        /// <summary>
        /// The workflow definition/configuration object<br/>
        /// Example: {"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}
        /// </summary>
        /// <example>{"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}</example>
        [global::Newtonsoft.Json.JsonProperty("contents", Required = global::Newtonsoft.Json.Required.Always)]
        public object Contents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseWorkflow" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </param>
        /// <param name="title">
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </param>
        /// <param name="userNickname">
        /// Display name/username of the owner<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="createdAt">
        /// ISO8601 timestamp of workflow creation<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="isPublic">
        /// Whether the workflow is publicly visible<br/>
        /// Example: true
        /// </param>
        /// <param name="contents">
        /// The workflow definition/configuration object<br/>
        /// Example: {"nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"model","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}},"output":{"id":"output","type":"output","depends":["node_a1b2c3"],"fields":{"image":"$node_a1b2c3.images.0.url"},"metadata":{"position":{"x":600,"y":100}}}}}
        /// </param>
        public GetWorkflowResponseWorkflow(
            string name,
            string title,
            string userNickname,
            string createdAt,
            bool isPublic,
            object contents)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UserNickname = userNickname ?? throw new global::System.ArgumentNullException(nameof(userNickname));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IsPublic = isPublic;
            this.Contents = contents ?? throw new global::System.ArgumentNullException(nameof(contents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseWorkflow" /> class.
        /// </summary>
        public GetWorkflowResponseWorkflow()
        {
        }
    }
}