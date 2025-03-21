//HintName: G.Models.RealtimeResponseCreateParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new Realtime response with these parameters
    /// </summary>
    public sealed partial class RealtimeResponseCreateParams
    {
        /// <summary>
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.OneOf<string, global::G.RealtimeResponseCreateParamsConversation?>? Conversation { get; set; }

        /// <summary>
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::System.Collections.Generic.IList<global::G.RealtimeConversationItemWithReference>? Input { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_response_output_tokens")]
        public global::G.OneOf<int?, global::G.RealtimeResponseCreateParamsMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeResponseCreateParamsModalitie>? Modalities { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_audio_format")]
        public global::G.RealtimeResponseCreateParamsOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function, like `{"type": "function", "function": {"name": "my_function"}}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.RealtimeResponseCreateParamsTool>? Tools { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.RealtimeResponseCreateParamsVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        /// <param name="conversation">
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </param>
        /// <param name="input">
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function, like `{"type": "function", "function": {"name": "my_function"}}`.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </param>
        public RealtimeResponseCreateParams(
            global::G.OneOf<string, global::G.RealtimeResponseCreateParamsConversation?>? conversation,
            global::System.Collections.Generic.IList<global::G.RealtimeConversationItemWithReference>? input,
            string? instructions,
            global::G.OneOf<int?, global::G.RealtimeResponseCreateParamsMaxResponseOutputTokens?>? maxResponseOutputTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::G.RealtimeResponseCreateParamsModalitie>? modalities,
            global::G.RealtimeResponseCreateParamsOutputAudioFormat? outputAudioFormat,
            double? temperature,
            string? toolChoice,
            global::System.Collections.Generic.IList<global::G.RealtimeResponseCreateParamsTool>? tools,
            global::G.RealtimeResponseCreateParamsVoice? voice)
        {
            this.Conversation = conversation;
            this.Input = input;
            this.Instructions = instructions;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.Metadata = metadata;
            this.Modalities = modalities;
            this.OutputAudioFormat = outputAudioFormat;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        public RealtimeResponseCreateParams()
        {
        }
    }
}