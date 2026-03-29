//HintName: G.Models.ValidatorReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference to a validator from the Guardrails Hub.
    /// </summary>
    public sealed partial class ValidatorReference
    {
        /// <summary>
        /// The unique identifier for this Validator. Often the hub id; e.g. guardrails/regex_match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A reference to the property this validator should be applied against. Can be a valid JSON path or a meta-property such as 'messages' or 'output'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        public string? On { get; set; }

        /// <summary>
        /// The action to take when validation fails.<br/>
        /// Default Value: noop
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onFail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValidatorReferenceOnFailJsonConverter))]
        public global::G.ValidatorReferenceOnFail? OnFail { get; set; }

        /// <summary>
        /// Positional arguments for the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<object>? Args { get; set; }

        /// <summary>
        /// Keyword arguments for the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kwargs")]
        public object? Kwargs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for this Validator. Often the hub id; e.g. guardrails/regex_match
        /// </param>
        /// <param name="on">
        /// A reference to the property this validator should be applied against. Can be a valid JSON path or a meta-property such as 'messages' or 'output'
        /// </param>
        /// <param name="onFail">
        /// The action to take when validation fails.<br/>
        /// Default Value: noop
        /// </param>
        /// <param name="args">
        /// Positional arguments for the validator.
        /// </param>
        /// <param name="kwargs">
        /// Keyword arguments for the validator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatorReference(
            string id,
            string? on,
            global::G.ValidatorReferenceOnFail? onFail,
            global::System.Collections.Generic.IList<object>? args,
            object? kwargs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.On = on;
            this.OnFail = onFail;
            this.Args = args;
            this.Kwargs = kwargs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorReference" /> class.
        /// </summary>
        public ValidatorReference()
        {
        }
    }
}