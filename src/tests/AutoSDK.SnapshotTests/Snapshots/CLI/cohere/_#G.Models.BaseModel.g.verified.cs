﻿//HintName: G.Models.BaseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base model used for fine-tuning.
    /// </summary>
    public sealed partial class BaseModel
    {
        /// <summary>
        /// The possible types of fine-tuned models.<br/>
        ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
        ///  - BASE_TYPE_GENERATIVE: Deprecated: Generative model.<br/>
        ///  - BASE_TYPE_CLASSIFICATION: Classification model.<br/>
        ///  - BASE_TYPE_RERANK: Rerank model.<br/>
        ///  - BASE_TYPE_CHAT: Chat model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </summary>
        /// <default>global::G.BaseType.UNSPECIFIED</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseType BaseType { get; set; } = global::G.BaseType.UNSPECIFIED;

        /// <summary>
        /// The name of the base model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The possible strategy used to serve a fine-tuned models.<br/>
        ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
        ///  - STRATEGY_VANILLA: Deprecated: Serve the fine-tuned model on a dedicated GPU.<br/>
        ///  - STRATEGY_TFEW: Deprecated: Serve the fine-tuned model on a shared GPU.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StrategyJsonConverter))]
        public global::G.Strategy? Strategy { get; set; }

        /// <summary>
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        /// <param name="baseType">
        /// The possible types of fine-tuned models.<br/>
        ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
        ///  - BASE_TYPE_GENERATIVE: Deprecated: Generative model.<br/>
        ///  - BASE_TYPE_CLASSIFICATION: Classification model.<br/>
        ///  - BASE_TYPE_RERANK: Rerank model.<br/>
        ///  - BASE_TYPE_CHAT: Chat model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </param>
        /// <param name="name">
        /// The name of the base model.
        /// </param>
        /// <param name="strategy">
        /// The possible strategy used to serve a fine-tuned models.<br/>
        ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
        ///  - STRATEGY_VANILLA: Deprecated: Serve the fine-tuned model on a dedicated GPU.<br/>
        ///  - STRATEGY_TFEW: Deprecated: Serve the fine-tuned model on a shared GPU.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </param>
        /// <param name="version">
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseModel(
            global::G.BaseType baseType,
            string? name,
            global::G.Strategy? strategy,
            string? version)
        {
            this.BaseType = baseType;
            this.Name = name;
            this.Strategy = strategy;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        public BaseModel()
        {
        }
    }
}