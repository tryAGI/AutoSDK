//HintName: G.Models.ImportProjectChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportProjectChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs")]
        public string? Vcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_name")]
        public string? HumanName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectChoice" /> class.
        /// </summary>
        /// <param name="vcs"></param>
        /// <param name="tfvcProject"></param>
        /// <param name="humanName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImportProjectChoice(
            string? vcs,
            string? tfvcProject,
            string? humanName)
        {
            this.Vcs = vcs;
            this.TfvcProject = tfvcProject;
            this.HumanName = humanName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectChoice" /> class.
        /// </summary>
        public ImportProjectChoice()
        {
        }
    }
}