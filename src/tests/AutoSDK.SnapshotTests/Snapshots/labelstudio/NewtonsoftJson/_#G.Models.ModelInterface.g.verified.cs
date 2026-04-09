//HintName: G.Models.ModelInterface.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInterface
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("associated_projects")]
        public global::System.Collections.Generic.IList<int>? AssociatedProjects { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple? CreatedBy { get; set; }

        /// <summary>
        /// Model description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SkillNameEnumJsonConverter))]
        public global::G.SkillNameEnum? SkillName { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInterface" /> class.
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
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public ModelInterface(
            string title,
            global::System.Collections.Generic.IList<int>? associatedProjects,
            global::G.UserSimple? createdBy,
            string? description,
            object? inputFields,
            int? organization,
            object? outputClasses,
            global::G.SkillNameEnum? skillName,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AssociatedProjects = associatedProjects;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.InputFields = inputFields;
            this.Organization = organization;
            this.OutputClasses = outputClasses;
            this.SkillName = skillName;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInterface" /> class.
        /// </summary>
        public ModelInterface()
        {
        }
    }
}