//HintName: G.Models.ConversationNodeVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationNodeVariant3
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ConversationNodeVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NodeInstruction Instruction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_response_edge")]
        public global::G.SkipResponseEdge? SkipResponseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("always_edge")]
        public global::G.AlwaysEdge? AlwaysEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_conversation_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneConversationExample>? FinetuneConversationExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </summary>
        /// <example>[kb_001, kb_002]</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// The tool ids of the tools defined in main conversation flow or component that can be used in this conversation node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// The tools owned by this conversation node. This includes other tool types like transfer_call, agent_swap, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNodeVariant3" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="skipResponseEdge"></param>
        /// <param name="alwaysEdge"></param>
        /// <param name="edges"></param>
        /// <param name="finetuneConversationExamples"></param>
        /// <param name="finetuneTransitionExamples"></param>
        /// <param name="knowledgeBaseIds">
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </param>
        /// <param name="toolIds">
        /// The tool ids of the tools defined in main conversation flow or component that can be used in this conversation node.
        /// </param>
        /// <param name="tools">
        /// The tools owned by this conversation node. This includes other tool types like transfer_call, agent_swap, etc.
        /// </param>
        public ConversationNodeVariant3(
            global::G.NodeInstruction instruction,
            global::G.ConversationNodeVariant3Type type,
            global::G.SkipResponseEdge? skipResponseEdge,
            global::G.AlwaysEdge? alwaysEdge,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneConversationExample>? finetuneConversationExamples,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<global::G.Tool>? tools)
        {
            this.Type = type;
            this.Instruction = instruction;
            this.SkipResponseEdge = skipResponseEdge;
            this.AlwaysEdge = alwaysEdge;
            this.Edges = edges;
            this.FinetuneConversationExamples = finetuneConversationExamples;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.ToolIds = toolIds;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNodeVariant3" /> class.
        /// </summary>
        public ConversationNodeVariant3()
        {
        }
    }
}