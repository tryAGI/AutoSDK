//HintName: G.Models.ModelInterfaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInterfaceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("associated_projects")]
        public global::System.Collections.Generic.IList<int>? AssociatedProjects { get; set; }

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Model description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_fields")]
        public object? InputFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_classes")]
        public object? OutputClasses { get; set; }

        /// <summary>
        /// Default Value: TextClassification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skill_name")]
        public global::G.SkillNameEnum? SkillName { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInterfaceRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Model name
        /// </param>
        /// <param name="associatedProjects"></param>
        /// <param name="createdBy">
        /// User who created Dataset
        /// </param>
        /// <param name="description">
        /// Model description
        /// </param>
        /// <param name="inputFields"></param>
        /// <param name="organization"></param>
        /// <param name="outputClasses"></param>
        /// <param name="skillName">
        /// Default Value: TextClassification
        /// </param>
        public ModelInterfaceRequest(
            string title,
            global::System.Collections.Generic.IList<int>? associatedProjects,
            global::G.UserSimpleRequest? createdBy,
            string? description,
            object? inputFields,
            int? organization,
            object? outputClasses,
            global::G.SkillNameEnum? skillName)
        {
            this.AssociatedProjects = associatedProjects;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.InputFields = inputFields;
            this.Organization = organization;
            this.OutputClasses = outputClasses;
            this.SkillName = skillName;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInterfaceRequest" /> class.
        /// </summary>
        public ModelInterfaceRequest()
        {
        }
    }
}