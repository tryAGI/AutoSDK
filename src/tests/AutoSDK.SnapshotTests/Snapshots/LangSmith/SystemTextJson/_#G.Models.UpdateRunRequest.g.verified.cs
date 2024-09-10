//HintName: G.Models.UpdateRunRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRunRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::System.Guid?, object>? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory3))]
        public global::G.OneOf<string, double?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.UpdateRunRequestInputs, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.UpdateRunRequestOutputs, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.UpdateRunRequestEventsVariant1Item>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.UpdateRunRequestExtra, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_attachments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.UpdateRunRequestInputAttachments, object>? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_attachments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.UpdateRunRequestOutputAttachments, object>? OutputAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}