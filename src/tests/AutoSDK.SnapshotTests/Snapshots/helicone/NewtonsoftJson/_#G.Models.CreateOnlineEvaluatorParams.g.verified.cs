//HintName: G.Models.CreateOnlineEvaluatorParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOnlineEvaluatorParams
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOnlineEvaluatorParams" /> class.
        /// </summary>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public CreateOnlineEvaluatorParams(
            global::G.RecordStringAny config)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOnlineEvaluatorParams" /> class.
        /// </summary>
        public CreateOnlineEvaluatorParams()
        {
        }
    }
}