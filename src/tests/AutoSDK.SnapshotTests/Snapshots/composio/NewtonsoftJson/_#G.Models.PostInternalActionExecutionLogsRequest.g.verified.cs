//HintName: G.Models.PostInternalActionExecutionLogsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsRequest
    {
        /// <summary>
        /// cursor_that_can_be_used_to_paginate_through_the_logs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public double? Cursor { get; set; }

        /// <summary>
        /// number_of_logs_to_return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// whether_the_search_is_case_sensitive_or_not
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// start_time_of_the_logs_in_epoch_time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public double? From { get; set; }

        /// <summary>
        /// end_time_of_the_logs_in_epoch_time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public double? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_params")]
        public global::System.Collections.Generic.IList<global::G.PostInternalActionExecutionLogsRequestSearchParam>? SearchParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsRequest" /> class.
        /// </summary>
        /// <param name="cursor">
        /// cursor_that_can_be_used_to_paginate_through_the_logs
        /// </param>
        /// <param name="limit">
        /// number_of_logs_to_return
        /// </param>
        /// <param name="caseSensitive">
        /// whether_the_search_is_case_sensitive_or_not
        /// </param>
        /// <param name="from">
        /// start_time_of_the_logs_in_epoch_time
        /// </param>
        /// <param name="to">
        /// end_time_of_the_logs_in_epoch_time
        /// </param>
        /// <param name="searchParams"></param>
        public PostInternalActionExecutionLogsRequest(
            double? cursor,
            double? limit,
            bool? caseSensitive,
            double? from,
            double? to,
            global::System.Collections.Generic.IList<global::G.PostInternalActionExecutionLogsRequestSearchParam>? searchParams)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.CaseSensitive = caseSensitive;
            this.From = from;
            this.To = to;
            this.SearchParams = searchParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsRequest" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsRequest()
        {
        }
    }
}