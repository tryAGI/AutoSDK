//HintName: G.Models.TableAppendSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableAppendSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("append", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TableAppendSpecPayload Append { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpec" /> class.
        /// </summary>
        /// <param name="append"></param>
        public TableAppendSpec(
            global::G.TableAppendSpecPayload append)
        {
            this.Append = append ?? throw new global::System.ArgumentNullException(nameof(append));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpec" /> class.
        /// </summary>
        public TableAppendSpec()
        {
        }
    }
}