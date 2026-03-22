//HintName: G.Models.BreakdownTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to break down the information. Cannot be "user" or "api_key" if include_workspace_metrics is False.
    /// </summary>
    public enum BreakdownTypes
    {
        /// <summary>
        /// 
        /// </summary>
        AllApiKeys,
        /// <summary>
        /// 
        /// </summary>
        ApiKeys,
        /// <summary>
        /// 
        /// </summary>
        Groups,
        /// <summary>
        /// 
        /// </summary>
        HasApiKey,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        ProductType,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        ReportingWorkspaceId,
        /// <summary>
        /// 
        /// </summary>
        RequestQueue,
        /// <summary>
        /// 
        /// </summary>
        RequestSource,
        /// <summary>
        /// 
        /// </summary>
        Resource,
        /// <summary>
        /// 
        /// </summary>
        SubresourceId,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
        VoiceMultiplier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BreakdownTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BreakdownTypes value)
        {
            return value switch
            {
                BreakdownTypes.AllApiKeys => "all_api_keys",
                BreakdownTypes.ApiKeys => "api_keys",
                BreakdownTypes.Groups => "groups",
                BreakdownTypes.HasApiKey => "has_api_key",
                BreakdownTypes.Model => "model",
                BreakdownTypes.None => "none",
                BreakdownTypes.ProductType => "product_type",
                BreakdownTypes.Region => "region",
                BreakdownTypes.ReportingWorkspaceId => "reporting_workspace_id",
                BreakdownTypes.RequestQueue => "request_queue",
                BreakdownTypes.RequestSource => "request_source",
                BreakdownTypes.Resource => "resource",
                BreakdownTypes.SubresourceId => "subresource_id",
                BreakdownTypes.User => "user",
                BreakdownTypes.Voice => "voice",
                BreakdownTypes.VoiceMultiplier => "voice_multiplier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BreakdownTypes? ToEnum(string value)
        {
            return value switch
            {
                "all_api_keys" => BreakdownTypes.AllApiKeys,
                "api_keys" => BreakdownTypes.ApiKeys,
                "groups" => BreakdownTypes.Groups,
                "has_api_key" => BreakdownTypes.HasApiKey,
                "model" => BreakdownTypes.Model,
                "none" => BreakdownTypes.None,
                "product_type" => BreakdownTypes.ProductType,
                "region" => BreakdownTypes.Region,
                "reporting_workspace_id" => BreakdownTypes.ReportingWorkspaceId,
                "request_queue" => BreakdownTypes.RequestQueue,
                "request_source" => BreakdownTypes.RequestSource,
                "resource" => BreakdownTypes.Resource,
                "subresource_id" => BreakdownTypes.SubresourceId,
                "user" => BreakdownTypes.User,
                "voice" => BreakdownTypes.Voice,
                "voice_multiplier" => BreakdownTypes.VoiceMultiplier,
                _ => null,
            };
        }
    }
}