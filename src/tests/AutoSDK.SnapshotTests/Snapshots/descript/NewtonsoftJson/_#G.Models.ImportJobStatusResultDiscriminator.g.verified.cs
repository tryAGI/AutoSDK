//HintName: G.Models.ImportJobStatusResultDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportJobStatusResultDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ImportJobStatusResultDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobStatusResultDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
        public ImportJobStatusResultDiscriminator(
            global::G.ImportJobStatusResultDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobStatusResultDiscriminator" /> class.
        /// </summary>
        public ImportJobStatusResultDiscriminator()
        {
        }
    }
}