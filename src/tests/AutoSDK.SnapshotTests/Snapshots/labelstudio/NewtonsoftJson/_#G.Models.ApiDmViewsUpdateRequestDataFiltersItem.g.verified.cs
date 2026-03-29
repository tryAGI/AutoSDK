//HintName: G.Models.ApiDmViewsUpdateRequestDataFiltersItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"filter":"filter:tasks:id","operator":"greater","type":"Number","value":123}
    /// </summary>
    public sealed partial class ApiDmViewsUpdateRequestDataFiltersItem
    {
        /// <summary>
        /// Filter identifier, it should start with `filter:tasks:` prefix, e.g. `filter:tasks:agreement`. For `task.data` fields it may look like `filter:tasks:data.field_name`. If you need more info about columns, check the [Get data manager columns](#tag/Data-Manager/operation/api_dm_columns_list) API endpoint. Possible values:&lt;li&gt;`filter:tasks:agreement` (Number) Agreement for annotation results for a specific task (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:annotations_results` (String) Annotation results for the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:annotators` (List) Annotators that completed the task (Community). Can include assigned annotators (Enterprise only). Important note: the filter `type` should be List, but the filter `value` is integer&lt;/li&gt;&lt;li&gt;`filter:tasks:cancelled_annotations` (Number) Number of cancelled or skipped annotations for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:comments` (Number) Number of comments in a task&lt;/li&gt;&lt;li&gt;`filter:tasks:completed_at` (Datetime) Time when a task was fully annotated&lt;/li&gt;&lt;li&gt;`filter:tasks:created_at` (Datetime) Time the task was created at&lt;/li&gt;&lt;li&gt;`filter:tasks:file_upload` (String) Name of the file uploaded to create the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:ground_truth` (Boolean) Ground truth status of the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:id` (Number) Task ID&lt;/li&gt;&lt;li&gt;`filter:tasks:inner_id` (Number) Task Inner ID, it starts from 1 for all projects&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_model_versions` (String) Model version used for the predictions&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_results` (String) Prediction results for the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_score` (Number) Prediction score for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:reviewed` (Boolean) Whether the tasks have been reviewed (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:reviewers` (String) Reviewers that reviewed the task, or assigned reviewers (Enterprise only). Important note: the filter `type` should be List, but the filter `value` is integer&lt;/li&gt;&lt;li&gt;`filter:tasks:reviews_accepted` (Number) Number of annotations accepted for a task in review (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:reviews_rejected` (Number) Number of annotations rejected for a task in review (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:total_annotations` (Number) Total number of annotations on a task&lt;/li&gt;&lt;li&gt;`filter:tasks:total_predictions` (Number) Total number of predictions for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:unresolved_comment_count` (Number) Number of unresolved comments in a task&lt;/li&gt;&lt;li&gt;`filter:tasks:updated_at` (Datetime) Time the task was updated at (e.g. new annotation was created, review added, etc)&lt;/li&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiDmViewsUpdateRequestDataFiltersItemFilter Filter { get; set; } = default!;

        /// <summary>
        /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiDmViewsUpdateRequestDataFiltersItemOperator Operator { get; set; } = default!;

        /// <summary>
        /// Type of the filter value. Possible values:&lt;li&gt;`Boolean` Boolean&lt;/li&gt;&lt;li&gt;`Datetime` Datetime string in `strftime('%Y-%m-%dT%H:%M:%S.%fZ')` format&lt;/li&gt;&lt;li&gt;`List` List of items&lt;/li&gt;&lt;li&gt;`Number` Float or Integer&lt;/li&gt;&lt;li&gt;`String` String&lt;/li&gt;&lt;li&gt;`Unknown` Unknown is explicitly converted to string format&lt;/li&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Value to filter by
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, int?, float?, bool?, object, object> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsUpdateRequestDataFiltersItem" /> class.
        /// </summary>
        /// <param name="filter">
        /// Filter identifier, it should start with `filter:tasks:` prefix, e.g. `filter:tasks:agreement`. For `task.data` fields it may look like `filter:tasks:data.field_name`. If you need more info about columns, check the [Get data manager columns](#tag/Data-Manager/operation/api_dm_columns_list) API endpoint. Possible values:&lt;li&gt;`filter:tasks:agreement` (Number) Agreement for annotation results for a specific task (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:annotations_results` (String) Annotation results for the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:annotators` (List) Annotators that completed the task (Community). Can include assigned annotators (Enterprise only). Important note: the filter `type` should be List, but the filter `value` is integer&lt;/li&gt;&lt;li&gt;`filter:tasks:cancelled_annotations` (Number) Number of cancelled or skipped annotations for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:comments` (Number) Number of comments in a task&lt;/li&gt;&lt;li&gt;`filter:tasks:completed_at` (Datetime) Time when a task was fully annotated&lt;/li&gt;&lt;li&gt;`filter:tasks:created_at` (Datetime) Time the task was created at&lt;/li&gt;&lt;li&gt;`filter:tasks:file_upload` (String) Name of the file uploaded to create the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:ground_truth` (Boolean) Ground truth status of the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:id` (Number) Task ID&lt;/li&gt;&lt;li&gt;`filter:tasks:inner_id` (Number) Task Inner ID, it starts from 1 for all projects&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_model_versions` (String) Model version used for the predictions&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_results` (String) Prediction results for the tasks&lt;/li&gt;&lt;li&gt;`filter:tasks:predictions_score` (Number) Prediction score for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:reviewed` (Boolean) Whether the tasks have been reviewed (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:reviewers` (String) Reviewers that reviewed the task, or assigned reviewers (Enterprise only). Important note: the filter `type` should be List, but the filter `value` is integer&lt;/li&gt;&lt;li&gt;`filter:tasks:reviews_accepted` (Number) Number of annotations accepted for a task in review (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:reviews_rejected` (Number) Number of annotations rejected for a task in review (Enterprise only)&lt;/li&gt;&lt;li&gt;`filter:tasks:total_annotations` (Number) Total number of annotations on a task&lt;/li&gt;&lt;li&gt;`filter:tasks:total_predictions` (Number) Total number of predictions for the task&lt;/li&gt;&lt;li&gt;`filter:tasks:unresolved_comment_count` (Number) Number of unresolved comments in a task&lt;/li&gt;&lt;li&gt;`filter:tasks:updated_at` (Datetime) Time the task was updated at (e.g. new annotation was created, review added, etc)&lt;/li&gt;
        /// </param>
        /// <param name="operator">
        /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </param>
        /// <param name="type">
        /// Type of the filter value. Possible values:&lt;li&gt;`Boolean` Boolean&lt;/li&gt;&lt;li&gt;`Datetime` Datetime string in `strftime('%Y-%m-%dT%H:%M:%S.%fZ')` format&lt;/li&gt;&lt;li&gt;`List` List of items&lt;/li&gt;&lt;li&gt;`Number` Float or Integer&lt;/li&gt;&lt;li&gt;`String` String&lt;/li&gt;&lt;li&gt;`Unknown` Unknown is explicitly converted to string format&lt;/li&gt;
        /// </param>
        /// <param name="value">
        /// Value to filter by
        /// </param>
        public ApiDmViewsUpdateRequestDataFiltersItem(
            global::G.ApiDmViewsUpdateRequestDataFiltersItemFilter filter,
            global::G.ApiDmViewsUpdateRequestDataFiltersItemOperator @operator,
            string type,
            global::G.OneOf<string, int?, float?, bool?, object, object> value)
        {
            this.Filter = filter;
            this.Operator = @operator;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsUpdateRequestDataFiltersItem" /> class.
        /// </summary>
        public ApiDmViewsUpdateRequestDataFiltersItem()
        {
        }
    }
}