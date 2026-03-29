//HintName: G.Models.LogExportsRequestedDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogExportsRequestedDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        AiModel,
        /// <summary>
        /// 
        /// </summary>
        AiOrg,
        /// <summary>
        /// 
        /// </summary>
        Config,
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CostCurrency,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        IsSuccess,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Mode,
        /// <summary>
        /// 
        /// </summary>
        PromptSlug,
        /// <summary>
        /// 
        /// </summary>
        ReqUnits,
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        RequestUrl,
        /// <summary>
        /// 
        /// </summary>
        ResUnits,
        /// <summary>
        /// 
        /// </summary>
        Response,
        /// <summary>
        /// 
        /// </summary>
        ResponseStatusCode,
        /// <summary>
        /// 
        /// </summary>
        ResponseTime,
        /// <summary>
        /// 
        /// </summary>
        TotalUnits,
        /// <summary>
        /// 
        /// </summary>
        TraceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogExportsRequestedDataItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogExportsRequestedDataItem value)
        {
            return value switch
            {
                LogExportsRequestedDataItem.AiModel => "ai_model",
                LogExportsRequestedDataItem.AiOrg => "ai_org",
                LogExportsRequestedDataItem.Config => "config",
                LogExportsRequestedDataItem.Cost => "cost",
                LogExportsRequestedDataItem.CostCurrency => "cost_currency",
                LogExportsRequestedDataItem.CreatedAt => "created_at",
                LogExportsRequestedDataItem.Id => "id",
                LogExportsRequestedDataItem.IsSuccess => "is_success",
                LogExportsRequestedDataItem.Metadata => "metadata",
                LogExportsRequestedDataItem.Mode => "mode",
                LogExportsRequestedDataItem.PromptSlug => "prompt_slug",
                LogExportsRequestedDataItem.ReqUnits => "req_units",
                LogExportsRequestedDataItem.Request => "request",
                LogExportsRequestedDataItem.RequestUrl => "request_url",
                LogExportsRequestedDataItem.ResUnits => "res_units",
                LogExportsRequestedDataItem.Response => "response",
                LogExportsRequestedDataItem.ResponseStatusCode => "response_status_code",
                LogExportsRequestedDataItem.ResponseTime => "response_time",
                LogExportsRequestedDataItem.TotalUnits => "total_units",
                LogExportsRequestedDataItem.TraceId => "trace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogExportsRequestedDataItem? ToEnum(string value)
        {
            return value switch
            {
                "ai_model" => LogExportsRequestedDataItem.AiModel,
                "ai_org" => LogExportsRequestedDataItem.AiOrg,
                "config" => LogExportsRequestedDataItem.Config,
                "cost" => LogExportsRequestedDataItem.Cost,
                "cost_currency" => LogExportsRequestedDataItem.CostCurrency,
                "created_at" => LogExportsRequestedDataItem.CreatedAt,
                "id" => LogExportsRequestedDataItem.Id,
                "is_success" => LogExportsRequestedDataItem.IsSuccess,
                "metadata" => LogExportsRequestedDataItem.Metadata,
                "mode" => LogExportsRequestedDataItem.Mode,
                "prompt_slug" => LogExportsRequestedDataItem.PromptSlug,
                "req_units" => LogExportsRequestedDataItem.ReqUnits,
                "request" => LogExportsRequestedDataItem.Request,
                "request_url" => LogExportsRequestedDataItem.RequestUrl,
                "res_units" => LogExportsRequestedDataItem.ResUnits,
                "response" => LogExportsRequestedDataItem.Response,
                "response_status_code" => LogExportsRequestedDataItem.ResponseStatusCode,
                "response_time" => LogExportsRequestedDataItem.ResponseTime,
                "total_units" => LogExportsRequestedDataItem.TotalUnits,
                "trace_id" => LogExportsRequestedDataItem.TraceId,
                _ => null,
            };
        }
    }
}