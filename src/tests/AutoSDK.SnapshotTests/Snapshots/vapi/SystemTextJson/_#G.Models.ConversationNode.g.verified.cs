//HintName: G.Models.ConversationNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationNode
    {
        /// <summary>
        /// This is the Conversation node. This can be used to start a conversation with the customer.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the conversation node<br/>
        /// - Model is active with the `prompt` and global context.<br/>
        /// - Model will call a tool to exit this node.<br/>
        /// - Workflow will extract variables from the conversation.<br/>
        /// - Workflow continues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationNodeTypeJsonConverter))]
        public global::G.ConversationNodeType Type { get; set; }

        /// <summary>
        /// This is the model for the node.<br/>
        /// This overrides `workflow.model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>))]
        public global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? Model { get; set; }

        /// <summary>
        /// This is the transcriber for the node.<br/>
        /// This overrides `workflow.transcriber`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>))]
        public global::G.OneOf<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>? Transcriber { get; set; }

        /// <summary>
        /// This is the voice for the node.<br/>
        /// This overrides `workflow.voice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>))]
        public global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// These are the tools that the conversation node can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? Tools { get; set; }

        /// <summary>
        /// These are the tools that the conversation node can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// This is the plan for the global node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalNodePlan")]
        public global::G.GlobalNodePlan? GlobalNodePlan { get; set; }

        /// <summary>
        /// This is the plan that controls the variable extraction from the user's responses.<br/>
        /// Usage:<br/>
        /// Use `schema` to specify what you want to extract from the user's responses.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "user": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "name": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "age": {<br/>
        ///             "type": "number"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ user.name }}` and `{{ user.age }}` respectively.<br/>
        /// (Optional) Use `aliases` to create new variables.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "userAge",<br/>
        ///       "value": "{{user.age}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "userName",<br/>
        ///       "value": "{{user.name}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ userAge }}` and `{{ userName }}` respectively.<br/>
        /// Note: The `schema` field is required for Conversation nodes if you want to extract variables from the user's responses. `aliases` is just a convenience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::G.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is whether or not the node is the start of the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStart")]
        public bool? IsStart { get; set; }

        /// <summary>
        /// This is for metadata you want to store on the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNode" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// This is the Conversation node. This can be used to start a conversation with the customer.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the conversation node<br/>
        /// - Model is active with the `prompt` and global context.<br/>
        /// - Model will call a tool to exit this node.<br/>
        /// - Workflow will extract variables from the conversation.<br/>
        /// - Workflow continues.
        /// </param>
        /// <param name="model">
        /// This is the model for the node.<br/>
        /// This overrides `workflow.model`.
        /// </param>
        /// <param name="transcriber">
        /// This is the transcriber for the node.<br/>
        /// This overrides `workflow.transcriber`.
        /// </param>
        /// <param name="voice">
        /// This is the voice for the node.<br/>
        /// This overrides `workflow.voice`.
        /// </param>
        /// <param name="tools">
        /// These are the tools that the conversation node can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="toolIds">
        /// These are the tools that the conversation node can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="globalNodePlan">
        /// This is the plan for the global node.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the plan that controls the variable extraction from the user's responses.<br/>
        /// Usage:<br/>
        /// Use `schema` to specify what you want to extract from the user's responses.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "user": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "name": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "age": {<br/>
        ///             "type": "number"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ user.name }}` and `{{ user.age }}` respectively.<br/>
        /// (Optional) Use `aliases` to create new variables.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "userAge",<br/>
        ///       "value": "{{user.age}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "userName",<br/>
        ///       "value": "{{user.name}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ userAge }}` and `{{ userName }}` respectively.<br/>
        /// Note: The `schema` field is required for Conversation nodes if you want to extract variables from the user's responses. `aliases` is just a convenience.
        /// </param>
        /// <param name="isStart">
        /// This is whether or not the node is the start of the workflow.
        /// </param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationNode(
            string name,
            global::G.ConversationNodeType type,
            global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? model,
            global::G.OneOf<global::G.AssemblyAITranscriber, global::G.AzureSpeechTranscriber, global::G.CustomTranscriber, global::G.DeepgramTranscriber, global::G.ElevenLabsTranscriber, global::G.GladiaTranscriber, global::G.GoogleTranscriber, global::G.SpeechmaticsTranscriber, global::G.TalkscriberTranscriber, global::G.OpenAITranscriber, global::G.CartesiaTranscriber, global::G.SonioxTranscriber>? transcriber,
            global::G.OneOf<global::G.AzureVoice, global::G.CartesiaVoice, global::G.CustomVoice, global::G.DeepgramVoice, global::G.ElevenLabsVoice, global::G.HumeVoice, global::G.LMNTVoice, global::G.NeuphonicVoice, global::G.OpenAIVoice, global::G.PlayHTVoice, global::G.WellSaidVoice, global::G.RimeAIVoice, global::G.SmallestAIVoice, global::G.TavusVoice, global::G.VapiVoice, global::G.SesameVoice, global::G.InworldVoice, global::G.MinimaxVoice>? voice,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            string? prompt,
            global::G.GlobalNodePlan? globalNodePlan,
            global::G.VariableExtractionPlan? variableExtractionPlan,
            bool? isStart,
            object? metadata)
        {
            this.Type = type;
            this.Model = model;
            this.Transcriber = transcriber;
            this.Voice = voice;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.Prompt = prompt;
            this.GlobalNodePlan = globalNodePlan;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsStart = isStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNode" /> class.
        /// </summary>
        public ConversationNode()
        {
        }
    }
}