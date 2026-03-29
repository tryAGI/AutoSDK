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
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalAssistantMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalToolResponseMessageEvaluation, global::G.ChatEvalUserMessageMock, global::G.ChatEvalAssistantMessageEvaluation>> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of the eval.<br/>
        /// It helps identify what the eval is checking for.<br/>
        /// Example: Verified User Flow Eval
        /// </summary>
        /// <example>Verified User Flow Eval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of the eval.<br/>
        /// This helps describe the eval and its purpose in detail. It will not be used to evaluate the flow of the conversation.<br/>
        /// Example: This eval checks if the user flow is verified.
        /// </summary>
        /// <example>This eval checks if the user flow is verified.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is the type of the eval.<br/>
        /// Currently it is fixed to `chat.mockConversation`.<br/>
        /// Example: chat.mockConversation
        /// </summary>
        /// <example>chat.mockConversation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalTypeJsonConverter))]
        public global::G.EvalType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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