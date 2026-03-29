//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// Unique identifier for the tool<br/>
        /// Example: github-actions
        /// </summary>
        /// <example>github-actions</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Human-readable display name of the tool<br/>
        /// Example: GitHub Actions
        /// </summary>
        /// <example>GitHub Actions</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Detailed explanation of the tool's functionality and purpose<br/>
        /// Example: Automate GitHub workflows including CI/CD, issue management, and release processes
        /// </summary>
        /// <example>Automate GitHub workflows including CI/CD, issue management, and release processes</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolToolkit Toolkit { get; set; } = default!;

        /// <summary>
        /// Schema definition of required input parameters for the tool<br/>
        /// Example: {"repo_name":{"type":"string","description":"GitHub repository name in owner/repo format","required":true,"example":"octocat/Hello-World"},"workflow_id":{"type":"string","description":"ID or filename of the workflow to trigger","required":true,"example":"main.yml"}}
        /// </summary>
        /// <example>{"repo_name":{"type":"string","description":"GitHub repository name in owner/repo format","required":true,"example":"octocat/Hello-World"},"workflow_id":{"type":"string","description":"ID or filename of the workflow to trigger","required":true,"example":"main.yml"}}</example>
        [global::Newtonsoft.Json.JsonProperty("input_parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> InputParameters { get; set; } = default!;

        /// <summary>
        /// Indicates if the tool can be used without authentication<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("no_auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool NoAuth { get; set; } = default!;

        /// <summary>
        /// List of all available versions for this tool<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </summary>
        /// <example>[20250905_00, 20250906_00]</example>
        [global::Newtonsoft.Json.JsonProperty("available_versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AvailableVersions { get; set; } = default!;

        /// <summary>
        /// Current version of the tool<br/>
        /// Example: 20250905_00
        /// </summary>
        /// <example>20250905_00</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Schema definition of return values from the tool<br/>
        /// Example: {"run_id":{"type":"number","description":"ID of the workflow run that was triggered","example":12345678},"status":{"type":"string","description":"Status of the workflow run","example":"completed","enum":["queued","in_progress","completed","failed"]}}
        /// </summary>
        /// <example>{"run_id":{"type":"number","description":"ID of the workflow run that was triggered","example":12345678},"status":{"type":"string","description":"Status of the workflow run","example":"completed","enum":["queued","in_progress","completed","failed"]}}</example>
        [global::Newtonsoft.Json.JsonProperty("output_parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> OutputParameters { get; set; } = default!;

        /// <summary>
        /// List of scopes associated with the tool<br/>
        /// Example: [https://www.googleapis.com/auth/gmail.modify]
        /// </summary>
        /// <example>[https://www.googleapis.com/auth/gmail.modify]</example>
        [global::Newtonsoft.Json.JsonProperty("scopes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Scopes { get; set; } = default!;

        /// <summary>
        /// Structured scope requirements for the tool. Null means the tool is legacy and only exposes flat scopes.<br/>
        /// Example: {"all_of":["read:user",{"any_of":["repo","public_repo"]}]}
        /// </summary>
        /// <example>{"all_of":["read:user",{"any_of":["repo","public_repo"]}]}</example>
        [global::Newtonsoft.Json.JsonProperty("scope_requirements")]
        public global::G.ToolScopeRequirements? ScopeRequirements { get; set; }

        /// <summary>
        /// List of tags associated with the tool for categorization and filtering<br/>
        /// Example: [ci-cd, github, automation, devops]
        /// </summary>
        /// <example>[ci-cd, github, automation, devops]</example>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Human-friendly description of the tool, if available<br/>
        /// Example: Create a new issue in a GitHub repository
        /// </summary>
        /// <example>Create a new issue in a GitHub repository</example>
        [global::Newtonsoft.Json.JsonProperty("human_description")]
        public string? HumanDescription { get; set; }

        /// <summary>
        /// Indicates if this tool is deprecated and may be removed in the future<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("is_deprecated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeprecated { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolDeprecated Deprecated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique identifier for the tool<br/>
        /// Example: github-actions
        /// </param>
        /// <param name="name">
        /// Human-readable display name of the tool<br/>
        /// Example: GitHub Actions
        /// </param>
        /// <param name="description">
        /// Detailed explanation of the tool's functionality and purpose<br/>
        /// Example: Automate GitHub workflows including CI/CD, issue management, and release processes
        /// </param>
        /// <param name="toolkit"></param>
        /// <param name="inputParameters">
        /// Schema definition of required input parameters for the tool<br/>
        /// Example: {"repo_name":{"type":"string","description":"GitHub repository name in owner/repo format","required":true,"example":"octocat/Hello-World"},"workflow_id":{"type":"string","description":"ID or filename of the workflow to trigger","required":true,"example":"main.yml"}}
        /// </param>
        /// <param name="noAuth">
        /// Indicates if the tool can be used without authentication<br/>
        /// Example: false
        /// </param>
        /// <param name="availableVersions">
        /// List of all available versions for this tool<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </param>
        /// <param name="version">
        /// Current version of the tool<br/>
        /// Example: 20250905_00
        /// </param>
        /// <param name="outputParameters">
        /// Schema definition of return values from the tool<br/>
        /// Example: {"run_id":{"type":"number","description":"ID of the workflow run that was triggered","example":12345678},"status":{"type":"string","description":"Status of the workflow run","example":"completed","enum":["queued","in_progress","completed","failed"]}}
        /// </param>
        /// <param name="scopes">
        /// List of scopes associated with the tool<br/>
        /// Example: [https://www.googleapis.com/auth/gmail.modify]
        /// </param>
        /// <param name="tags">
        /// List of tags associated with the tool for categorization and filtering<br/>
        /// Example: [ci-cd, github, automation, devops]
        /// </param>
        /// <param name="isDeprecated">
        /// Indicates if this tool is deprecated and may be removed in the future<br/>
        /// Example: false
        /// </param>
        /// <param name="deprecated"></param>
        /// <param name="scopeRequirements">
        /// Structured scope requirements for the tool. Null means the tool is legacy and only exposes flat scopes.<br/>
        /// Example: {"all_of":["read:user",{"any_of":["repo","public_repo"]}]}
        /// </param>
        /// <param name="humanDescription">
        /// Human-friendly description of the tool, if available<br/>
        /// Example: Create a new issue in a GitHub repository
        /// </param>
        public Tool(
            string slug,
            string name,
            string description,
            global::G.ToolToolkit toolkit,
            global::System.Collections.Generic.Dictionary<string, object?> inputParameters,
            bool noAuth,
            global::System.Collections.Generic.IList<string> availableVersions,
            string version,
            global::System.Collections.Generic.Dictionary<string, object?> outputParameters,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<string> tags,
            bool isDeprecated,
            global::G.ToolDeprecated deprecated,
            global::G.ToolScopeRequirements? scopeRequirements,
            string? humanDescription)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.InputParameters = inputParameters ?? throw new global::System.ArgumentNullException(nameof(inputParameters));
            this.NoAuth = noAuth;
            this.AvailableVersions = availableVersions ?? throw new global::System.ArgumentNullException(nameof(availableVersions));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.OutputParameters = outputParameters ?? throw new global::System.ArgumentNullException(nameof(outputParameters));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.ScopeRequirements = scopeRequirements;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.HumanDescription = humanDescription;
            this.IsDeprecated = isDeprecated;
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}