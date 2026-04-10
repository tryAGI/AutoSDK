//HintName: G.Models.ModelCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCost
    {
        /// <summary>
        /// This is the type of cost, always 'model' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelCostTypeJsonConverter))]
        public global::G.ModelCostType Type { get; set; }

        /// <summary>
        /// This is the model that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.model`,<br/>
        /// - `call.assistantId-&gt;model`,<br/>
        /// - `call.squad[n].assistant.model`,<br/>
        /// - `call.squad[n].assistantId-&gt;model`,<br/>
        /// - `call.squadId-&gt;[n].assistant.model`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of cached prompt tokens used in the call. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedPromptTokens")]
        public double? CachedPromptTokens { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCost" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.model`,<br/>
        /// - `call.assistantId-&gt;model`,<br/>
        /// - `call.squad[n].assistant.model`,<br/>
        /// - `call.squad[n].assistantId-&gt;model`,<br/>
        /// - `call.squadId-&gt;[n].assistant.model`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'model' for this class.
        /// </param>
        /// <param name="cachedPromptTokens">
        /// This is the number of cached prompt tokens used in the call. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </param>
        public ModelCost(
            object model,
            double promptTokens,
            double completionTokens,
            double cost,
            global::G.ModelCostType type,
            double? cachedPromptTokens)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedPromptTokens = cachedPromptTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCost" /> class.
        /// </summary>
        public ModelCost()
        {
        }
    }
}