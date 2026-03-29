//HintName: G.Models.ServiceTogglesConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceTogglesConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pythonEvaluatorEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PythonEvaluatorEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceThreadPythonEvaluatorEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TraceThreadPythonEvaluatorEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spanLlmAsJudgeEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SpanLlmAsJudgeEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spanUserDefinedMetricPythonEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SpanUserDefinedMetricPythonEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrailsEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool GuardrailsEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opikAIEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OpikAIEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alertsEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AlertsEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("welcomeWizardEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool WelcomeWizardEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("csvUploadEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CsvUploadEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExportEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizationStudioEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OptimizationStudioEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetVersioningEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DatasetVersioningEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetExportEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DatasetExportEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openaiProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OpenaiProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anthropicProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AnthropicProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geminiProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool GeminiProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openrouterProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OpenrouterProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vertexaiProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool VertexaiProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bedrockProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool BedrockProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customllmProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CustomllmProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ollamaProviderEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OllamaProviderEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaboratorsTabEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CollaboratorsTabEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantSidebarEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AssistantSidebarEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forceWorkspaceVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForceWorkspaceVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceTogglesConfig" /> class.
        /// </summary>
        /// <param name="pythonEvaluatorEnabled"></param>
        /// <param name="traceThreadPythonEvaluatorEnabled"></param>
        /// <param name="spanLlmAsJudgeEnabled"></param>
        /// <param name="spanUserDefinedMetricPythonEnabled"></param>
        /// <param name="guardrailsEnabled"></param>
        /// <param name="opikAIEnabled"></param>
        /// <param name="alertsEnabled"></param>
        /// <param name="welcomeWizardEnabled"></param>
        /// <param name="csvUploadEnabled"></param>
        /// <param name="exportEnabled"></param>
        /// <param name="optimizationStudioEnabled"></param>
        /// <param name="datasetVersioningEnabled"></param>
        /// <param name="datasetExportEnabled"></param>
        /// <param name="openaiProviderEnabled"></param>
        /// <param name="anthropicProviderEnabled"></param>
        /// <param name="geminiProviderEnabled"></param>
        /// <param name="openrouterProviderEnabled"></param>
        /// <param name="vertexaiProviderEnabled"></param>
        /// <param name="bedrockProviderEnabled"></param>
        /// <param name="customllmProviderEnabled"></param>
        /// <param name="ollamaProviderEnabled"></param>
        /// <param name="collaboratorsTabEnabled"></param>
        /// <param name="assistantSidebarEnabled"></param>
        /// <param name="forceWorkspaceVersion"></param>
        public ServiceTogglesConfig(
            bool pythonEvaluatorEnabled,
            bool traceThreadPythonEvaluatorEnabled,
            bool spanLlmAsJudgeEnabled,
            bool spanUserDefinedMetricPythonEnabled,
            bool guardrailsEnabled,
            bool opikAIEnabled,
            bool alertsEnabled,
            bool welcomeWizardEnabled,
            bool csvUploadEnabled,
            bool exportEnabled,
            bool optimizationStudioEnabled,
            bool datasetVersioningEnabled,
            bool datasetExportEnabled,
            bool openaiProviderEnabled,
            bool anthropicProviderEnabled,
            bool geminiProviderEnabled,
            bool openrouterProviderEnabled,
            bool vertexaiProviderEnabled,
            bool bedrockProviderEnabled,
            bool customllmProviderEnabled,
            bool ollamaProviderEnabled,
            bool collaboratorsTabEnabled,
            bool assistantSidebarEnabled,
            string forceWorkspaceVersion)
        {
            this.PythonEvaluatorEnabled = pythonEvaluatorEnabled;
            this.TraceThreadPythonEvaluatorEnabled = traceThreadPythonEvaluatorEnabled;
            this.SpanLlmAsJudgeEnabled = spanLlmAsJudgeEnabled;
            this.SpanUserDefinedMetricPythonEnabled = spanUserDefinedMetricPythonEnabled;
            this.GuardrailsEnabled = guardrailsEnabled;
            this.OpikAIEnabled = opikAIEnabled;
            this.AlertsEnabled = alertsEnabled;
            this.WelcomeWizardEnabled = welcomeWizardEnabled;
            this.CsvUploadEnabled = csvUploadEnabled;
            this.ExportEnabled = exportEnabled;
            this.OptimizationStudioEnabled = optimizationStudioEnabled;
            this.DatasetVersioningEnabled = datasetVersioningEnabled;
            this.DatasetExportEnabled = datasetExportEnabled;
            this.OpenaiProviderEnabled = openaiProviderEnabled;
            this.AnthropicProviderEnabled = anthropicProviderEnabled;
            this.GeminiProviderEnabled = geminiProviderEnabled;
            this.OpenrouterProviderEnabled = openrouterProviderEnabled;
            this.VertexaiProviderEnabled = vertexaiProviderEnabled;
            this.BedrockProviderEnabled = bedrockProviderEnabled;
            this.CustomllmProviderEnabled = customllmProviderEnabled;
            this.OllamaProviderEnabled = ollamaProviderEnabled;
            this.CollaboratorsTabEnabled = collaboratorsTabEnabled;
            this.AssistantSidebarEnabled = assistantSidebarEnabled;
            this.ForceWorkspaceVersion = forceWorkspaceVersion ?? throw new global::System.ArgumentNullException(nameof(forceWorkspaceVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceTogglesConfig" /> class.
        /// </summary>
        public ServiceTogglesConfig()
        {
        }
    }
}