//HintName: G.Models.TablePopSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablePopSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pop", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TablePopSpecPayload Pop { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePopSpec" /> class.
        /// </summary>
        /// <param name="pop"></param>
        public TablePopSpec(
            global::G.TablePopSpecPayload pop)
        {
            this.Pop = pop ?? throw new global::System.ArgumentNullException(nameof(pop));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePopSpec" /> class.
        /// </summary>
        public TablePopSpec()
        {
        }
    }
}