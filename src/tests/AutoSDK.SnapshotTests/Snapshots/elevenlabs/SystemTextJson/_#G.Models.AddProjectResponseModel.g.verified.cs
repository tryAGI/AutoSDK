//HintName: G.Models.AddProjectResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectResponseModel
    {
        /// <summary>
        /// Example: {"access_level":"viewer","author":"John Doe","can_be_downloaded":true,"content_type":"Novel","cover_image_url":"https://example.com/cover.jpg","create_date_unix":1714204800,"creation_meta":{"creation_progress":0.5,"status":"pending","type":"blank"},"default_model_id":"eleven_multilingual_v2","default_paragraph_voice_id":"JBFqnCBsd6RMkjVDRZzb","default_title_voice_id":"JBFqnCBsd6RMkjVDRZzb","description":"This is a description of my project.","fiction":"fiction","genres":["Novel","Short Story"],"isbn_number":"978-90-274-3964-2","language":"en","last_conversion_date_unix":1714204800,"mature_content":false,"name":"My Project","original_publication_date":"2025-01-01","project_id":"aw1NgEzBg83R7vgmiJt6","quality_check_on":false,"quality_check_on_when_bulk_convert":false,"state":"default","target_audience":"Young Adults","title":"My Project","volume_normalization":true}
        /// </summary>
        /// <example>{"access_level":"viewer","author":"John Doe","can_be_downloaded":true,"content_type":"Novel","cover_image_url":"https://example.com/cover.jpg","create_date_unix":1714204800,"creation_meta":{"creation_progress":0.5,"status":"pending","type":"blank"},"default_model_id":"eleven_multilingual_v2","default_paragraph_voice_id":"JBFqnCBsd6RMkjVDRZzb","default_title_voice_id":"JBFqnCBsd6RMkjVDRZzb","description":"This is a description of my project.","fiction":"fiction","genres":["Novel","Short Story"],"isbn_number":"978-90-274-3964-2","language":"en","last_conversion_date_unix":1714204800,"mature_content":false,"name":"My Project","original_publication_date":"2025-01-01","project_id":"aw1NgEzBg83R7vgmiJt6","quality_check_on":false,"quality_check_on_when_bulk_convert":false,"state":"default","target_audience":"Young Adults","title":"My Project","volume_normalization":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectResponseModel Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        /// <param name="project">
        /// Example: {"access_level":"viewer","author":"John Doe","can_be_downloaded":true,"content_type":"Novel","cover_image_url":"https://example.com/cover.jpg","create_date_unix":1714204800,"creation_meta":{"creation_progress":0.5,"status":"pending","type":"blank"},"default_model_id":"eleven_multilingual_v2","default_paragraph_voice_id":"JBFqnCBsd6RMkjVDRZzb","default_title_voice_id":"JBFqnCBsd6RMkjVDRZzb","description":"This is a description of my project.","fiction":"fiction","genres":["Novel","Short Story"],"isbn_number":"978-90-274-3964-2","language":"en","last_conversion_date_unix":1714204800,"mature_content":false,"name":"My Project","original_publication_date":"2025-01-01","project_id":"aw1NgEzBg83R7vgmiJt6","quality_check_on":false,"quality_check_on_when_bulk_convert":false,"state":"default","target_audience":"Young Adults","title":"My Project","volume_normalization":true}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectResponseModel(
            global::G.ProjectResponseModel project)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        public AddProjectResponseModel()
        {
        }
    }
}