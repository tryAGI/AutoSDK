//HintName: G.Models.Eval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Eval
    {
        /// <summary>
        /// This is the mock conversation that will be used to evaluate the flow of the conversation.<br/>
        /// Mock Messages are used to simulate the flow of the conversation<br/>
        /// Evaluation Messages are used as checkpoints in the flow where the model's response to previous conversation needs to be evaluated to check the content and tool calls<br/>
        /// Example: [{ role: "user", content: "Hello, how are you?" }, { role: "assistant", judgePlan: { type: "exact", content: "I am good, thank you!" } }]
        /// </summary>
        /// <example>[{ role: "user", content: "Hello, how are you?" }, { role: "assistant", judgePlan: { type: "exact", content: "I am good, thank you!" } }]</example>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalAssistantMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalToolResponseMessageEvaluation, global::G.ChatEvalUserMessageMock, global::G.ChatEvalAssistantMessageEvaluation>> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of the eval.<br/>
        /// It helps identify what the eval is checking for.<br/>
        /// Example: Verified User Flow Eval
        /// </summary>
        /// <example>Verified User Flow Eval</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of the eval.<br/>
        /// This helps describe the eval and its purpose in detail. It will not be used to evaluate the flow of the conversation.<br/>
        /// Example: This eval checks if the user flow is verified.
        /// </summary>
        /// <example>This eval checks if the user flow is verified.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is the type of the eval.<br/>
        /// Currently it is fixed to `chat.mockConversation`.<br/>
        /// Example: chat.mockConversation
        /// </summary>
        /// <example>chat.mockConversation</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        /// <param name="messages">
        /// This is the mock conversation that will be used to evaluate the flow of the conversation.<br/>
        /// Mock Messages are used to simulate the flow of the conversation<br/>
        /// Evaluation Messages are used as checkpoints in the flow where the model's response to previous conversation needs to be evaluated to check the content and tool calls<br/>
        /// Example: [{ role: "user", content: "Hello, how are you?" }, { role: "assistant", judgePlan: { type: "exact", content: "I am good, thank you!" } }]
        /// </param>
        /// <param name="id"></param>
        /// <param name="orgId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name">
        /// This is the name of the eval.<br/>
        /// It helps identify what the eval is checking for.<br/>
        /// Example: Verified User Flow Eval
        /// </param>
        /// <param name="description">
        /// This is the description of the eval.<br/>
        /// This helps describe the eval and its purpose in detail. It will not be used to evaluate the flow of the conversation.<br/>
        /// Example: This eval checks if the user flow is verified.
        /// </param>
        /// <param name="type">
        /// This is the type of the eval.<br/>
        /// Currently it is fixed to `chat.mockConversation`.<br/>
        /// Example: chat.mockConversation
        /// </param>
        public Eval(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalAssistantMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalToolResponseMessageEvaluation, global::G.ChatEvalUserMessageMock, global::G.ChatEvalAssistantMessageEvaluation>> messages,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            string? description,
            global::G.EvalType type)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        public Eval()
        {
        }
    }
}