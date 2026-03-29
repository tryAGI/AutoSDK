//HintName: G.Models.TableInsertSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableInsertSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insert", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TableInsertSpecPayload Insert { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpec" /> class.
        /// </summary>
        /// <param name="insert"></param>
        public TableInsertSpec(
            global::G.TableInsertSpecPayload insert)
        {
            this.Insert = insert ?? throw new global::System.ArgumentNullException(nameof(insert));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpec" /> class.
        /// </summary>
        public TableInsertSpec()
        {
        }
    }
}