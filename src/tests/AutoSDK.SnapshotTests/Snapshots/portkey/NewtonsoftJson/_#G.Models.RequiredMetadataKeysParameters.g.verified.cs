//HintName: G.Models.RequiredMetadataKeysParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequiredMetadataKeysParameters
    {
        /// <summary>
        /// Metadata keys to check for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadataKeys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> MetadataKeys { get; set; } = default!;

        /// <summary>
        /// Operator to use for key checking<br/>
        /// Default Value: all
        /// </summary>
        /// <default>global::G.RequiredMetadataKeysParametersOperator.All</default>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter))]
        public global::G.RequiredMetadataKeysParametersOperator Operator { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredMetadataKeysParameters" /> class.
        /// </summary>
        /// <param name="metadataKeys">
        /// Metadata keys to check for
        /// </param>
        /// <param name="operator">
        /// Operator to use for key checking<br/>
        /// Default Value: all
        /// </param>
        public RequiredMetadataKeysParameters(
            global::System.Collections.Generic.IList<string> metadataKeys,
            global::G.RequiredMetadataKeysParametersOperator @operator)
        {
            this.MetadataKeys = metadataKeys ?? throw new global::System.ArgumentNullException(nameof(metadataKeys));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredMetadataKeysParameters" /> class.
        /// </summary>
        public RequiredMetadataKeysParameters()
        {
        }
    }
}