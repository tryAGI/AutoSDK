﻿//HintName: G.Models.ChecksCreateRequestOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
    /// </summary>
    public sealed partial class ChecksCreateRequestOutput
    {
        /// <summary>
        /// The title of the check run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The summary of the check run. This parameter supports Markdown. **Maximum length**: 65535 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// The details of the check run. This parameter supports Markdown. **Maximum length**: 65535 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/checks/runs#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. GitHub Actions are limited to 10 warning annotations and 10 error annotations per step. For details about how you can view annotations on GitHub, see "[About status checks](https://docs.github.com/articles/about-status-checks#checks)".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::G.ChecksCreateRequestOutputAnnotation>? Annotations { get; set; }

        /// <summary>
        /// Adds images to the output displayed in the GitHub pull request UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::G.ChecksCreateRequestOutputImage>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestOutput" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the check run.
        /// </param>
        /// <param name="summary">
        /// The summary of the check run. This parameter supports Markdown. **Maximum length**: 65535 characters.
        /// </param>
        /// <param name="text">
        /// The details of the check run. This parameter supports Markdown. **Maximum length**: 65535 characters.
        /// </param>
        /// <param name="annotations">
        /// Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/checks/runs#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. GitHub Actions are limited to 10 warning annotations and 10 error annotations per step. For details about how you can view annotations on GitHub, see "[About status checks](https://docs.github.com/articles/about-status-checks#checks)".
        /// </param>
        /// <param name="images">
        /// Adds images to the output displayed in the GitHub pull request UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksCreateRequestOutput(
            string title,
            string summary,
            string? text,
            global::System.Collections.Generic.IList<global::G.ChecksCreateRequestOutputAnnotation>? annotations,
            global::System.Collections.Generic.IList<global::G.ChecksCreateRequestOutputImage>? images)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Text = text;
            this.Annotations = annotations;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestOutput" /> class.
        /// </summary>
        public ChecksCreateRequestOutput()
        {
        }
    }
}