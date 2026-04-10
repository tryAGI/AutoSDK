//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Opik REST API is currently in beta and subject to change. If you have any questions or feedback about the APIs, please reach out on GitHub: https://github.com/comet-ml/opik.<br/>
    /// All of the methods listed in this documentation are used by either the SDK or the UI to interact with the Opik server. As a result,<br/>
    /// the methods have been optimized for these use-cases in mind. If you are looking for a method that is not listed above, please create<br/>
    /// and issue on GitHub or raise a PR!<br/>
    /// Opik includes two main deployment options that results in slightly different API usage:<br/>
    /// - **Self-hosted Opik instance:** You will simply need to specify the URL as `http://localhost:5173/api/&lt;endpoint_path&gt;` or similar. This is the default option for the docs.<br/>
    /// - **Opik Cloud:** You will need to specify the Opik API Key and Opik Workspace in the header. The format of the header should be:<br/>
    ///   ```<br/>
    ///   {<br/>
    ///     "Comet-Workspace": "your-workspace-name",<br/>
    ///     "authorization": "your-api-key"<br/>
    ///   }<br/>
    ///   ```<br/>
    ///   The full payload would therefore look like:<br/>
    ///   <br/>
    ///   ```<br/>
    ///   curl -X GET 'https://www.comet.com/opik/api/v1/private/projects' \<br/>
    ///   -H 'Accept: application/json' \<br/>
    ///   -H 'Comet-Workspace: &lt;your-workspace-name&gt;' \<br/>
    ///   -H 'authorization: &lt;your-api-key&gt;'<br/>
    ///   ```<br/>
    ///   Do take note here that the authorization header value does not include the `Bearer ` prefix. To switch to using the Opik Cloud in the documentation, you can<br/>
    ///   click on the edit button displayed when hovering over the `Base URL` displayed on the right hand side of the docs.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Local server
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:5173/api";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.AgentBlueprintWriteTypeJsonConverter(),

                    new global::G.JsonConverters.AgentBlueprintWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValueWriteTypeJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValueWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentBlueprintPublicTypeJsonConverter(),

                    new global::G.JsonConverters.AgentBlueprintPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValuePublicTypeJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValuePublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentBlueprintHistoryTypeJsonConverter(),

                    new global::G.JsonConverters.AgentBlueprintHistoryTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValueHistoryTypeJsonConverter(),

                    new global::G.JsonConverters.AgentConfigValueHistoryTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertAlertTypeJsonConverter(),

                    new global::G.JsonConverters.AlertAlertTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerEventTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerWriteEventTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerWriteEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertWriteAlertTypeJsonConverter(),

                    new global::G.JsonConverters.AlertWriteAlertTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigPublicTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerConfigPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerPublicEventTypeJsonConverter(),

                    new global::G.JsonConverters.AlertTriggerPublicEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AlertPublicAlertTypeJsonConverter(),

                    new global::G.JsonConverters.AlertPublicAlertTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebhookTestResultStatusJsonConverter(),

                    new global::G.JsonConverters.WebhookTestResultStatusNullableJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueueScopeJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueueScopeNullableJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueueWriteScopeJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueueWriteScopeNullableJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueuePublicScopeJsonConverter(),

                    new global::G.JsonConverters.AnnotationQueuePublicScopeNullableJsonConverter(),

                    new global::G.JsonConverters.CompleteMultipartUploadRequestEntityTypeJsonConverter(),

                    new global::G.JsonConverters.CompleteMultipartUploadRequestEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteAttachmentsRequestEntityTypeJsonConverter(),

                    new global::G.JsonConverters.DeleteAttachmentsRequestEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.StartMultipartUploadRequestEntityTypeJsonConverter(),

                    new global::G.JsonConverters.StartMultipartUploadRequestEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorActionJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorActionNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessageRoleJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaTypeJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanFilterOperatorJsonConverter(),

                    new global::G.JsonConverters.SpanFilterOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceFilterOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceFilterOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteActionJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteActionNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessageWriteRoleJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessageWriteRoleNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanFilterWriteOperatorJsonConverter(),

                    new global::G.JsonConverters.SpanFilterWriteOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceFilterWriteOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceFilterWriteOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterWriteOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterWriteOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessagePublicRoleJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeMessagePublicRoleNullableJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeJsonConverter(),

                    new global::G.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanFilterPublicOperatorJsonConverter(),

                    new global::G.JsonConverters.SpanFilterPublicOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceFilterPublicOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceFilterPublicOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterPublicOperatorJsonConverter(),

                    new global::G.JsonConverters.TraceThreadFilterPublicOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicActionJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicActionNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LogItemLevelJsonConverter(),

                    new global::G.JsonConverters.LogItemLevelNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateActionJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateActionNullableJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageRoleJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolTypeJsonConverter(),

                    new global::G.JsonConverters.ToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DashboardPublicTypeJsonConverter(),

                    new global::G.JsonConverters.DashboardPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DashboardPublicScopeJsonConverter(),

                    new global::G.JsonConverters.DashboardPublicScopeNullableJsonConverter(),

                    new global::G.JsonConverters.DashboardWriteTypeJsonConverter(),

                    new global::G.JsonConverters.DashboardWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DashboardUpdatePublicTypeJsonConverter(),

                    new global::G.JsonConverters.DashboardUpdatePublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemPublicTypeJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetItemFilterOperatorJsonConverter(),

                    new global::G.JsonConverters.DatasetItemFilterOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemTypeJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetTypeJsonConverter(),

                    new global::G.JsonConverters.DatasetTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetVisibilityJsonConverter(),

                    new global::G.JsonConverters.DatasetVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetStatusJsonConverter(),

                    new global::G.JsonConverters.DatasetStatusNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetWriteTypeJsonConverter(),

                    new global::G.JsonConverters.DatasetWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetWriteVisibilityJsonConverter(),

                    new global::G.JsonConverters.DatasetWriteVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetItemSourceJsonConverter(),

                    new global::G.JsonConverters.DatasetItemSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemTraceVisibilityModeJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemTraceVisibilityModeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ValueEntrySourceJsonConverter(),

                    new global::G.JsonConverters.ValueEntrySourceNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetItemWriteSourceJsonConverter(),

                    new global::G.JsonConverters.DatasetItemWriteSourceNullableJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemWriteTypeJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ColumnCompareTypeJsonConverter(),

                    new global::G.JsonConverters.ColumnCompareTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetItemCompareSourceJsonConverter(),

                    new global::G.JsonConverters.DatasetItemCompareSourceNullableJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemCompareTypeJsonConverter(),

                    new global::G.JsonConverters.EvaluatorItemCompareTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemCompareTraceVisibilityModeJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemCompareTraceVisibilityModeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemCompareStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemCompareStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryCompareStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryCompareStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreCompareSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreCompareSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ValueEntryCompareSourceJsonConverter(),

                    new global::G.JsonConverters.ValueEntryCompareSourceNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicTypeJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicVisibilityJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicStatusJsonConverter(),

                    new global::G.JsonConverters.DatasetPublicStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectStatItemObjectPublicTypeJsonConverter(),

                    new global::G.JsonConverters.ProjectStatItemObjectPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetExportJobPublicStatusJsonConverter(),

                    new global::G.JsonConverters.DatasetExportJobPublicStatusNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetItemPublicSourceJsonConverter(),

                    new global::G.JsonConverters.DatasetItemPublicSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemPublicTraceVisibilityModeJsonConverter(),

                    new global::G.JsonConverters.ExperimentItemPublicTraceVisibilityModeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryPublicStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentRunSummaryPublicStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ColumnPublicTypeJsonConverter(),

                    new global::G.JsonConverters.ColumnPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ColumnTypeJsonConverter(),

                    new global::G.JsonConverters.ColumnTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetUpdateVisibilityJsonConverter(),

                    new global::G.JsonConverters.DatasetUpdateVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentUpdateTypeJsonConverter(),

                    new global::G.JsonConverters.ExperimentUpdateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentUpdateStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentUpdateStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentTypeJsonConverter(),

                    new global::G.JsonConverters.ExperimentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentEvaluationMethodJsonConverter(),

                    new global::G.JsonConverters.ExperimentEvaluationMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteTypeJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteEvaluationMethodJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteEvaluationMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentWriteStatusNullableJsonConverter(),

                    new global::G.JsonConverters.CheckNameJsonConverter(),

                    new global::G.JsonConverters.CheckNameNullableJsonConverter(),

                    new global::G.JsonConverters.CheckResultJsonConverter(),

                    new global::G.JsonConverters.CheckResultNullableJsonConverter(),

                    new global::G.JsonConverters.SpanTypeJsonConverter(),

                    new global::G.JsonConverters.SpanTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanSourceJsonConverter(),

                    new global::G.JsonConverters.SpanSourceNullableJsonConverter(),

                    new global::G.JsonConverters.TraceVisibilityModeJsonConverter(),

                    new global::G.JsonConverters.TraceVisibilityModeNullableJsonConverter(),

                    new global::G.JsonConverters.TraceSourceJsonConverter(),

                    new global::G.JsonConverters.TraceSourceNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceNullableJsonConverter(),

                    new global::G.JsonConverters.SpanExperimentItemBulkWriteViewTypeJsonConverter(),

                    new global::G.JsonConverters.SpanExperimentItemBulkWriteViewTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanExperimentItemBulkWriteViewSourceJsonConverter(),

                    new global::G.JsonConverters.SpanExperimentItemBulkWriteViewSourceNullableJsonConverter(),

                    new global::G.JsonConverters.TraceExperimentItemBulkWriteViewSourceJsonConverter(),

                    new global::G.JsonConverters.TraceExperimentItemBulkWriteViewSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceJsonConverter(),

                    new global::G.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicTypeJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicEvaluationMethodJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicEvaluationMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicStatusJsonConverter(),

                    new global::G.JsonConverters.ExperimentPublicStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackCreateTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackCreateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackCreateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackCreateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackObjectPublicTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackObjectPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackObjectPublicDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackObjectPublicDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackPublicTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackPublicDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackPublicDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackUpdateTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackUpdateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackUpdateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FeedbackUpdateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailNameJsonConverter(),

                    new global::G.JsonConverters.GuardrailNameNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailResultJsonConverter(),

                    new global::G.JsonConverters.GuardrailResultNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailWriteNameJsonConverter(),

                    new global::G.JsonConverters.GuardrailWriteNameNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailWriteResultJsonConverter(),

                    new global::G.JsonConverters.GuardrailWriteResultNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyPublicProviderJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyPublicProviderNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyProviderJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyProviderNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyWriteProviderJsonConverter(),

                    new global::G.JsonConverters.ProviderApiKeyWriteProviderNullableJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerJobStatusJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerJobStatusNullableJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerStatusJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerStatusNullableJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerJobResultRequestStatusJsonConverter(),

                    new global::G.JsonConverters.LocalRunnerJobResultRequestStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ManualEvaluationRequestEntityTypeJsonConverter(),

                    new global::G.JsonConverters.ManualEvaluationRequestEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OptimizationStatusJsonConverter(),

                    new global::G.JsonConverters.OptimizationStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OptimizationWriteStatusJsonConverter(),

                    new global::G.JsonConverters.OptimizationWriteStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OptimizationPublicStatusJsonConverter(),

                    new global::G.JsonConverters.OptimizationPublicStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OptimizationUpdateStatusJsonConverter(),

                    new global::G.JsonConverters.OptimizationUpdateStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPublicTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptPublicTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectVisibilityJsonConverter(),

                    new global::G.JsonConverters.ProjectVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectWriteVisibilityJsonConverter(),

                    new global::G.JsonConverters.ProjectWriteVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectPublicVisibilityJsonConverter(),

                    new global::G.JsonConverters.ProjectPublicVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.KpiMetricTypeJsonConverter(),

                    new global::G.JsonConverters.KpiMetricTypeNullableJsonConverter(),

                    new global::G.JsonConverters.KpiCardRequestEntityTypeJsonConverter(),

                    new global::G.JsonConverters.KpiCardRequestEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricResponsePublicMetricTypeJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricResponsePublicMetricTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricResponsePublicIntervalJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricResponsePublicIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.BreakdownConfigPublicFieldJsonConverter(),

                    new global::G.JsonConverters.BreakdownConfigPublicFieldNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricRequestPublicMetricTypeJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricRequestPublicMetricTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricRequestPublicIntervalJsonConverter(),

                    new global::G.JsonConverters.ProjectMetricRequestPublicIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectDetailedVisibilityJsonConverter(),

                    new global::G.JsonConverters.ProjectDetailedVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectUpdateVisibilityJsonConverter(),

                    new global::G.JsonConverters.ProjectUpdateVisibilityNullableJsonConverter(),

                    new global::G.JsonConverters.PromptTypeJsonConverter(),

                    new global::G.JsonConverters.PromptTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionTypeJsonConverter(),

                    new global::G.JsonConverters.PromptVersionTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptVersionTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.PromptWriteTypeJsonConverter(),

                    new global::G.JsonConverters.PromptWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptWriteTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptWriteTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionDetailTypeJsonConverter(),

                    new global::G.JsonConverters.PromptVersionDetailTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionDetailTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptVersionDetailTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.CreatePromptVersionDetailTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.CreatePromptVersionDetailTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.PromptDetailTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptDetailTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPublicTypeJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPublicTemplateStructureJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPublicTemplateStructureNullableJsonConverter(),

                    new global::G.JsonConverters.RetentionRulePublicLevelJsonConverter(),

                    new global::G.JsonConverters.RetentionRulePublicLevelNullableJsonConverter(),

                    new global::G.JsonConverters.RetentionRulePublicRetentionJsonConverter(),

                    new global::G.JsonConverters.RetentionRulePublicRetentionNullableJsonConverter(),

                    new global::G.JsonConverters.RetentionRuleWriteRetentionJsonConverter(),

                    new global::G.JsonConverters.RetentionRuleWriteRetentionNullableJsonConverter(),

                    new global::G.JsonConverters.SpanUpdateTypeJsonConverter(),

                    new global::G.JsonConverters.SpanUpdateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanUpdateSourceJsonConverter(),

                    new global::G.JsonConverters.SpanUpdateSourceNullableJsonConverter(),

                    new global::G.JsonConverters.SpanWriteTypeJsonConverter(),

                    new global::G.JsonConverters.SpanWriteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanWriteSourceJsonConverter(),

                    new global::G.JsonConverters.SpanWriteSourceNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScorePublicSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScorePublicSourceNullableJsonConverter(),

                    new global::G.JsonConverters.SpanPublicTypeJsonConverter(),

                    new global::G.JsonConverters.SpanPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanPublicSourceJsonConverter(),

                    new global::G.JsonConverters.SpanPublicSourceNullableJsonConverter(),

                    new global::G.JsonConverters.ValueEntryPublicSourceJsonConverter(),

                    new global::G.JsonConverters.ValueEntryPublicSourceNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreBatchItemSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreBatchItemSourceNullableJsonConverter(),

                    new global::G.JsonConverters.SpanSearchStreamRequestPublicTypeJsonConverter(),

                    new global::G.JsonConverters.SpanSearchStreamRequestPublicTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TraceUpdateSourceJsonConverter(),

                    new global::G.JsonConverters.TraceUpdateSourceNullableJsonConverter(),

                    new global::G.JsonConverters.TraceWriteSourceJsonConverter(),

                    new global::G.JsonConverters.TraceWriteSourceNullableJsonConverter(),

                    new global::G.JsonConverters.CheckPublicNameJsonConverter(),

                    new global::G.JsonConverters.CheckPublicNameNullableJsonConverter(),

                    new global::G.JsonConverters.CheckPublicResultJsonConverter(),

                    new global::G.JsonConverters.CheckPublicResultNullableJsonConverter(),

                    new global::G.JsonConverters.TracePublicVisibilityModeJsonConverter(),

                    new global::G.JsonConverters.TracePublicVisibilityModeNullableJsonConverter(),

                    new global::G.JsonConverters.TracePublicSourceJsonConverter(),

                    new global::G.JsonConverters.TracePublicSourceNullableJsonConverter(),

                    new global::G.JsonConverters.TraceThreadStatusJsonConverter(),

                    new global::G.JsonConverters.TraceThreadStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreBatchItemThreadSourceJsonConverter(),

                    new global::G.JsonConverters.FeedbackScoreBatchItemThreadSourceNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceVersionOpikVersionJsonConverter(),

                    new global::G.JsonConverters.WorkspaceVersionOpikVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetWebhookExamplesAlertTypeJsonConverter(),

                    new global::G.JsonConverters.GetWebhookExamplesAlertTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AttachmentListEntityTypeJsonConverter(),

                    new global::G.JsonConverters.AttachmentListEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DownloadAttachmentEntityTypeJsonConverter(),

                    new global::G.JsonConverters.DownloadAttachmentEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UploadAttachmentEntityTypeJsonConverter(),

                    new global::G.JsonConverters.UploadAttachmentEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FindFeedbackDefinitionsTypeJsonConverter(),

                    new global::G.JsonConverters.FindFeedbackDefinitionsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetSpansByProjectTypeJsonConverter(),

                    new global::G.JsonConverters.GetSpansByProjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FindFeedbackScoreNames1TypeJsonConverter(),

                    new global::G.JsonConverters.FindFeedbackScoreNames1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetSpanStatsTypeJsonConverter(),

                    new global::G.JsonConverters.GetSpanStatsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Agent configuration management.
        /// </summary>
        public AgentConfigsClient AgentConfigs => new AgentConfigsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Alert resources.
        /// </summary>
        public AlertsClient Alerts => new AlertsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private annotation queue operations.
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Assistant Sidebar configuration.
        /// </summary>
        public AssistantSidebarsClient AssistantSidebars => new AssistantSidebarsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Attachments related resources.
        /// </summary>
        public AttachmentsClient Attachments => new AttachmentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Automation rule evaluators resource.
        /// </summary>
        public AutomationRuleEvaluatorsClient AutomationRuleEvaluators => new AutomationRuleEvaluatorsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Chat Completions related resources.
        /// </summary>
        public ChatCompletionsClient ChatCompletions => new ChatCompletionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access check resources.
        /// </summary>
        public CheckClient Check => new CheckClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace Dashboard resources.
        /// </summary>
        public DashboardsClient Dashboards => new DashboardsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Dataset resources.
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Experiment resources.
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Feedback definitions related resources.
        /// </summary>
        public FeedbackDefinitionsClient FeedbackDefinitions => new FeedbackDefinitionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Guardrails related resources.
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Insights View resources.
        /// </summary>
        public InsightsViewsClient InsightsViews => new InsightsViewsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// LLM model registry resources.
        /// </summary>
        public LlmModelsClient LlmModels => new LlmModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// LLM Provider Key.
        /// </summary>
        public LlmProviderKeyClient LlmProviderKey => new LlmProviderKeyClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manual evaluation resources for traces, threads, and spans.
        /// </summary>
        public ManualEvaluationClient ManualEvaluation => new ManualEvaluationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Ollama provider configuration endpoints with OpenAI-compatible API support.
        /// </summary>
        public OllamaClient Ollama => new OllamaClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Ollie pod state persistence.
        /// </summary>
        public OllieStateClient OllieState => new OllieStateClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Resource to ingest Traces and Spans via OpenTelemetry.
        /// </summary>
        public OpenTelemetryIngestionClient OpenTelemetryIngestion => new OpenTelemetryIngestionClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Optimization resources.
        /// </summary>
        public OptimizationsClient Optimizations => new OptimizationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Project related resources.
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Prompt resources.
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Redirects for SDK generated links.
        /// </summary>
        public RedirectClient Redirect => new RedirectClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Data retention rule management.
        /// </summary>
        public RetentionRulesClient RetentionRules => new RetentionRulesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Local runner management endpoints.
        /// </summary>
        public RunnersClient Runners => new RunnersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Service Toggles resources.
        /// </summary>
        public ServiceTogglesClient ServiceToggles => new ServiceTogglesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Span related resources.
        /// </summary>
        public SpansClient Spans => new SpansClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// System usage related resource.
        /// </summary>
        public SystemUsageClient SystemUsage => new SystemUsageClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Trace related resources.
        /// </summary>
        public TracesClient Traces => new TracesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Welcome wizard tracking resources.
        /// </summary>
        public WelcomeWizardClient WelcomeWizard => new WelcomeWizardClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace permissions related resources.
        /// </summary>
        public WorkspacePermissionsClient WorkspacePermissions => new WorkspacePermissionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace related resources.
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}