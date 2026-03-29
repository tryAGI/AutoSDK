//HintName: G.Models.JSONKeysParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONKeysParameters
    {
        /// <summary>
        /// Keys to check for in JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// Operator to use for key checking<br/>
        /// Default Value: any
        /// </summary>
        /// <default>global::G.JSONKeysParametersOperator.Any</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JSONKeysParametersOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JSONKeysParametersOperator Operator { get; set; } = global::G.JSONKeysParametersOperator.Any;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONKeysParameters" /> class.
        /// </summary>
        /// <param name="keys">
        /// Keys to check for in JSON
        /// </param>
        /// <param name="operator">
        /// Operator to use for key checking<br/>
        /// Default Value: any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONKeysParameters(
            global::System.Collections.Generic.IList<string> keys,
            global::G.JSONKeysParametersOperator @operator)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONKeysParameters" /> class.
        /// </summary>
        public JSONKeysParameters()
        {
        }
    }
}