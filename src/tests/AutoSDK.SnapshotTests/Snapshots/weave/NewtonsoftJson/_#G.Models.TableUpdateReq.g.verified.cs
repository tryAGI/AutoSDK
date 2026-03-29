//HintName: G.Models.TableUpdateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableUpdateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseDigest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TableAppendSpec, global::G.TablePopSpec, global::G.TableInsertSpec>> Updates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="baseDigest"></param>
        /// <param name="updates"></param>
        public TableUpdateReq(
            string projectId,
            string baseDigest,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TableAppendSpec, global::G.TablePopSpec, global::G.TableInsertSpec>> updates)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BaseDigest = baseDigest ?? throw new global::System.ArgumentNullException(nameof(baseDigest));
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateReq" /> class.
        /// </summary>
        public TableUpdateReq()
        {
        }
    }
}